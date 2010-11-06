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
	public class LockStatementTests
	{
		#region C#
		[Test]
		public void CSharpLockStatementTest()
		{
			LockStatement lockStmt = ParseUtilCSharp.ParseStatement<LockStatement>("lock (myObj) {}");
			// TODO : Extend test.
		}
		#endregion
		
		#region VB.NET
			// No VB.NET representation
		#endregion
	}
}
