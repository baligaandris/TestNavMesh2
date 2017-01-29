using UnityEngine;
using System.Collections;

public class Activateagent : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
        GetComponent<NavMeshAgent>().SetDestination(GameObject.Find("Target").transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
