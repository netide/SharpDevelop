@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.6.6484 NetIde.ICSharpCode.TextEditor.nuspec
