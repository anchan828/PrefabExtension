using UnityEditor;

public class EditorExample
{
	[MenuItem("PrefabExtension/ApplyPrefabState")]
	static void ApplyPrefabState ()
	{
		Selection.gameObjects.ApplyPrefabState (false);
	}
}