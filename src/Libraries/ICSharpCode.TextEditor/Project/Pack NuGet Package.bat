@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.5.6482 NetIde.ICSharpCode.TextEditor.nuspec
