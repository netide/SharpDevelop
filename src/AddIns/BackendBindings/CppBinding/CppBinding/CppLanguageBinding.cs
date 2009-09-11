/*
 * Created by SharpDevelop.
 * User: trecio
 * Date: 2009-05-31
 * Time: 22:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using ICSharpCode.CppBinding.Project;
using ICSharpCode.SharpDevelop.Internal.Templates;
using ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.CppBinding
{
	/// <summary>
	/// Description of CppLanguageBinding.
	/// </summary>
	public class CppLanguageBinding : IProjectBinding
	{
		public const string LanguageName = "C++";
		
		public string Language {
			get {
				return LanguageName;
			}
		}

		public readonly static CppLanguageProperties LanguageProperties = new CppLanguageProperties();

		public IProject LoadProject(ProjectLoadInformation info) {
			return new CppProject(info);
		}
		
		public IProject CreateProject(ProjectCreateInformation info) {
			info.Platform = "Win32";
			return new CppProject(info);
		}
	}
}
