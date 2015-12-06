using UnityEditor;
using System.Linq;

public class BuildScript
{
	static void Android()
	{
		BuildPipeline.BuildPlayer(GetScenes(), "game.apk", BuildTarget.Android, BuildOptions.None);
	}

	static string[] GetScenes()
	{
		return EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
	}
}
