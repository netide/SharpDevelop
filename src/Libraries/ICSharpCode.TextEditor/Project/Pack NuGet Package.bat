@echo off

nuget.exe pack -build -prop configuration=release -version 3.3.7.6487 NetIde.ICSharpCode.TextEditor.nuspec
