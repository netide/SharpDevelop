@echo off

nuget.exe pack -build -prop configuration=release -version 3.2.1.6473 NetIde.ICSharpCode.TextEditor.nuspec
