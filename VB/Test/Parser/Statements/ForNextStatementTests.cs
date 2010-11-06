﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.IO;
using NUnit.Framework;
using ICSharpCode.NRefactory.VB.Parser;
using ICSharpCode.NRefactory.VB.Dom;

namespace ICSharpCode.NRefactory.VB.Tests.Dom
{
	[TestFixture]
	public class ForNextStatementTests
	{
		#region C#
		// No C# representation
		#endregion
		
		#region VB.NET
		[Test]
		public void VBNetForNextStatementTest()
		{
			ForNextStatement forNextStatement = ParseUtilVBNet.ParseStatement<ForNextStatement>("For i=0 To 10 Step 2 : Next i");
		}
		
		[Test]
		public void VBNetForNextStatementWithComplexExpressionTest()
		{
			ForNextStatement forNextStatement = ParseUtilVBNet.ParseStatement<ForNextStatement>("For SomeMethod().Property = 0 To 10 : Next SomeMethod().Property");
		}
		#endregion
	}
}
