using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cards : MonoBehaviour {


	private List<int> cards = new List<int>();
	private List<int> cardsOnHand = new List<int>();

	// Use this for initialization
	void Start () {
		cards = new Shuffle ().GetDeck ();
		int startCardCount = 0;
		while (startCardCount < 5) {
			cardsOnHand.Add(cards[0]);
			cards.RemoveAt(0);
			startCardCount++;
		}
		Test ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void Test(){
		string testStr = "";
		foreach (int con in cardsOnHand) {
			testStr += con.ToString() + " ";
		}
		Debug.Log (testStr);

	}
}
