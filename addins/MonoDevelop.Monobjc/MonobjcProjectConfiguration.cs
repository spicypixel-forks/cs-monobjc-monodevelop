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
using MonoDevelop.Projects;

namespace MonoDevelop.Monobjc
{
	/// <summary>
	///   A Monobjc project configuration.
	/// </summary>
	public class MonobjcProjectConfiguration : DotNetProjectConfiguration
	{
		/// <summary>
		///   Initializes a new instance of the <see cref = "MonobjcProjectConfiguration" /> class.
		/// </summary>
		public MonobjcProjectConfiguration ()
		{
		}

		/// <summary>
		///   Initializes a new instance of the <see cref = "MonobjcProjectConfiguration" /> class.
		/// </summary>
		/// <param name = "name">The name.</param>
		public MonobjcProjectConfiguration (String name) : base(name)
		{
		}

		/// <summary>
		///   Gets or sets the name of the application.
		/// </summary>
		/// <value>The name of the application.</value>
		public String ApplicationName { get; set; }

		/// <summary>
		///   Gets or sets the runtime.
		/// </summary>
		/// <value>The runtime.</value>
		public String Runtime { get; set; }
	}
}