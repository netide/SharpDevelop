@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.3.6477 NetIde.ICSharpCode.TextEditor.nuspec
