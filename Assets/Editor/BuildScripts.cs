using UnityEngine;
using UnityEditor;

public class BuildScripts {
	static void PerformBuild() {
		string[] scenes = {"Assets/Scenes/SampleScene.unity"};
		BuildPipeline.BuildPlayer(scenes, "iOSBuild", BuildTarget.iOS, BuildOptions.None);
	}
}
