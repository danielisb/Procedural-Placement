using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralGO : MonoBehaviour {    

    public GameObject rocksObj;
    public int numberOfRocks;

    void Start() {

        for( int i = 0; i < numberOfRocks; i++) {

            //this.gameObject.transform.position  = Vector3(transform.localPosition.x + Random.Range(-40.0, 40.0), transform.localPosition.y, transform.localPosition.z + Random.Range(-40.0, 40.0));
            Instantiate(rocksObj,this.transform.position, transform.rotation);
        }
    }        
    // [Range(0, 1)]
    // public float rockDensity;
    // public int rockSpacing;
    // public int totalPositions;
    // public int availablePositions;

    // public LayerMask obstacle;
    // public GameObject[] environmentObjects;
    // public GameObject rockFolder;

    // void Start() {

    //     totalPositions = Grid.instance.walkableVector3s.Count;
    //     availablePositions = totalPositions;
    //     Debug.Log("Total available positions: " + totalPositions);

    //     environmentObjects = new GameObjectp[1];
    //     environmentObjects[0] = Resources.Load("Rocks and Boulders 2/Rocks/Prefabs/Rock1_grup1") as GameObject;

    //     placeVegetation(rockDensity, rockSpacing, 4, 7, obstacle, rockFolder);
    // }

    // private void placeVegetation(float density, GameObject vegToPlace, GameObject parent) {

    //     int vegDensity = (int)(totalPositions * density);
    //     Debug.Log(vegDensity + " " + parent.name);

    //     if (availablePositions > 0) {

    //         for (int i = 0; i < vegDensity; i++) {

    //             Vector3 position = Grid.instance.walkableVector3s[Random.Range(0, Grid.instance.walkableVector3s.Count)];
    //             GameObject veg = Instantiate(vegToPlace, position, vegToPlace.transform.rotation);
    //             Quaternion rotation = Random.rotation;
    //             rotation.x = veg.transform.rotation.x;
    //             rotation.z = veg.transform.rotation.z;
    //             veg.transform.rotation = rotation;
    //             veg.transform.SetParent(parent.transform);
    //             Grid.instance.walkableVector3s.Remove(position);
    //             availablePositions = Grid.instance.walkableVector3s.Count;
    //         }
    //     }
    // }
}
