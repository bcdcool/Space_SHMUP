using UnityEngine;
using System.Collections;

public class Enemy_1 : Enemy {
    public float waveFrequency = 2;
    public float waveWidth = 4;
    public float waveRotY = 45;

    public float x0 = -1234;
    private float birthTime;

    void Start()
    {
        x0 = pos.x;

        birthTime = Time.time;
    }

    public override void Move()
    {
        Vector3 tempPos = pos;

        float age = Time.time - birthTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;
        pos = tempPos; 
    }


}
