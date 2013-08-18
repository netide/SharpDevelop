@echo off

nuget.exe pack -build -prop configuration=release -version 3.2.1.6471 NetIde.ICSharpCode.TextEditor.nuspec
