using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public Wave wave;
}

[System.Serializable]
public struct Wave
{
    public EnemyData[] enemyDatas;
}
[System.Serializable]
public struct EnemyData
{
    public string enemyName;
    public int spawnAmount;
}