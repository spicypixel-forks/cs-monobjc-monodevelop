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
namespace MonoDevelop.Monobjc
{
	/// <summary>
	/// Define the type of the executable project.
	/// </summary>
	public enum MonobjcProjectType
	{
		/// <summary>
		/// No type.
		/// </summary>
		None = 0,
		/// <summary>
		/// The project generates a bundled application.
		/// </summary>
		CocoaApplication,
		/// <summary>
		/// The project generates a console application.
		/// </summary>
		ConsoleApplication,
		/// <summary>
		/// The project generates a cocoa library.
		/// </summary>
		CocoaLibrary,
	}
}
