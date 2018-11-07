using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    ObjPool objPooler;
    public Transform R;
    public Transform G;
    public Transform B;


    private void Start()
    {
        objPooler = ObjPool.Instance;
    }
    void FixedUpdate () {
        objPooler.SpawnFromPool("Red", R.transform.position, Quaternion.identity);
        objPooler.SpawnFromPool("Green", G.transform.position, Quaternion.identity);
        objPooler.SpawnFromPool("Blue", B.transform.position, Quaternion.identity);

    }
}
