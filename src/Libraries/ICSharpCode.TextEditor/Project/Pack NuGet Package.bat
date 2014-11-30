@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.4.6480 NetIde.ICSharpCode.TextEditor.nuspec
