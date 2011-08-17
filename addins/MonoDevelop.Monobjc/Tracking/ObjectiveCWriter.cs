//
// This file is part of Monobjc, a .NET/Objective-C bridge
// Copyright (C) 2007-2011 - Laurent Etiemble
//
// Monobjc is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// Monobjc is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Monobjc.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections.Generic;
using System.IO;
using MonoDevelop.Monobjc.Utilities;
using MonoDevelop.Projects.Dom;

namespace MonoDevelop.Monobjc.Tracking
{
	public abstract class ObjectiveCWriter
	{
		protected MonobjcProject project;
		
		protected ObjectiveCWriter (MonobjcProject project)
		{
			this.project = project;
		}
		
		public void Write (TextWriter writer, IType type)
		{
			String name = type.Name;
			String baseName = (type.BaseType != null) ? type.BaseType.Name : "NSObject";
			
			WriteHeader (writer);
			WriteIncludes (writer, type);
			
			WritePrologue (writer, name, baseName);
			WriteProperties (writer, type);
			WriteMethods (writer, type);
			WriteEpilogue (writer, name, baseName);
		}
		
		protected void WriteHeader (TextWriter writer)
		{
			writer.WriteLine ("//");
			writer.WriteLine ("// Generated by Monobjc MonoDevelop Addin");
			writer.WriteLine ("//");
		}
		
		protected void WriteIncludes (TextWriter writer, IType type)
		{
			foreach (String framework in this.project.OSFrameworks.Split(';')) {
				writer.WriteLine ("#import <{0}/{0}.h>", framework);
			}
			foreach(String import in this.GetOtherImports(type)) {
				writer.WriteLine (import);
			}
			writer.WriteLine ();
		}
		
		protected abstract void WritePrologue (TextWriter writer, String name, String baseName);
		
		protected abstract void WriteProperties (TextWriter writer, IType type);
		
		protected abstract void WriteMethods (TextWriter writer, IType type);
		
		protected abstract void WriteEpilogue (TextWriter writer, String name, String baseName);
		
		protected abstract IEnumerable<String> GetOtherImports (IType type);
		
		protected IEnumerable<IProperty> GetProperties(IType type) {
			IList<IProperty> properties = new List<IProperty>();
			foreach (IProperty property in type.Properties) {
				if (!AttributeHelper.HasAttribute (property, AttributeHelper.IBOUTLET)) {
					continue;
				}
				if (!AttributeHelper.HasAttribute (property, AttributeHelper.OBJECTIVE_C_IVAR)) {
					continue;
				}
				properties.Add(property);
			}
			return properties;
		}
		
		protected IEnumerable<IMethod> GetMethods(IType type) {
			IList<IMethod> methods = new List<IMethod>();
			foreach (IMethod method in type.Methods) {
				if (!AttributeHelper.HasAttribute (method, AttributeHelper.IBACTION)) {
					continue;
				}
				if (!AttributeHelper.HasAttribute (method, AttributeHelper.OBJECTIVE_C_MESSAGE)) {
					continue;
				}
				if (method.Parameters.Count != 1) {
					continue;
				}
				methods.Add(method);
			}
			return methods;
		}
	}
}