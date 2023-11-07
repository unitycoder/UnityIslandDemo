using UnityEditor;

public static class ReserializeAssets
{
    [MenuItem("Edit/Reserialize All Assets")]
    private static void ReserializeAllAssets()
    {
        AssetDatabase.ForceReserializeAssets();
    }
}
