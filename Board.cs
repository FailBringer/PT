using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour {

	// Use this for initialization
	public class Map {
		public int[] avanguard = new int[3];
		public int[] flank = new int[2];
		public int Leader;
		public int[] rear = new int[3];
	}

	private Map myMap;
	private Map enemyMap;

	void Start () {
		myMap = new Map ();
		enemyMap = new Map();
		myMap.avanguard [2] = 1;
		Debug.Log(myMap.avanguard[2].ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
