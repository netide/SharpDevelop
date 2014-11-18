@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.2.6475 NetIde.ICSharpCode.TextEditor.nuspec
