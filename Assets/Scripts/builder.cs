using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class builder : MonoBehaviour {

    [Header("Terrain")]
    public Vector3 terrainArea; // the terrain you wants to place random objects
    
    [Header("Prefab")]
    public GameObject prefab;

    [Header("Clones")]
    public int amountClones; // how many objects you want to place inside the terrain area

    [Header("Size Settings")]
    public float minSize, maxSize;
    
    private float xMinimum, xMaximum, zMinimum, yMinimum, zMaximum;
    
    private void Start() {

        GameObject findTerrain = GameObject.Find("Terrain");
        Terrain terrain = findTerrain.GetComponent<Terrain>();
        
        terrainArea = terrain.terrainData.size;
        xMinimum = transform.position.x;
        zMinimum = transform.position.z;
        xMaximum = xMinimum + terrainArea.x;
        zMaximum = zMinimum + terrainArea.z;

        for (int i=0; i < amountClones; i++) {

            SetPrefab();
        }
    }

    private void SetPrefab() {

        GameObject objPos = new GameObject();
        objPos.transform.position = new Vector3(Random.Range(xMinimum, xMaximum), 100f, Random.Range(zMinimum, zMaximum));
        objPos.name = "Builder";

        RaycastHit hit;
        Ray getHeight = new Ray(objPos.transform.position, Vector3.down); // height reference to create the prefab

        if (Physics.Raycast (getHeight, out hit, 100)) {
            
            prefab = Instantiate(prefab, hit.point, Quaternion.identity);
            SetRandomPosition();
            SetRandomRotation();
            SetRandomScale();
            prefab.transform.parent = this.transform;
        }        
        Destroy(objPos);
    }

    void SetRandomPosition() {

        prefab.transform.position = new Vector3(prefab.transform.position.x, prefab.transform.position.y, prefab.transform.position.z);
    }

    void SetRandomRotation() {

        prefab.transform.rotation = Quaternion.Euler(prefab.transform.rotation.x, (Random.Range(0.0f, 360.0f)), prefab.transform.rotation.x);
    }

    void SetRandomScale() {

        var randomSize = Random.Range(minSize, maxSize);        
        prefab.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
    }
}
