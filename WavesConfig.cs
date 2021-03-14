using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "Enemy/WaveConfig", order = 0)]
public class WavesConfig : ScriptableObject
{
    

    [Serializable]
    
    public class EnemyConfigs
    {
        


        public EnemyControler EnemyPrebafbs;
        public Vector3 spawnRefencePosition;
        public bool useSpecificXPosition;




    }
    public List<EnemyConfigs> enemies;
    public float cadence;







}
