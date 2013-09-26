using UnityEngine;
using System.Collections;

public class gamefuntions : MonoBehaviour {

	public GameObject otherGameObject;

	private Player player;
	private Control control;

	// Use this for initialization
	void Awake () {
		player = GetComponent<Player>();
		control = otherGameObject.GetComponent<Control>();
	}
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		if (player.curHealth == 0){
			Application.LoadLevel("death_Screen");
		}
	}
}
