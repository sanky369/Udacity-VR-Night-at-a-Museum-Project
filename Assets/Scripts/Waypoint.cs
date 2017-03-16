using UnityEngine;
using System.Collections;
using RenderHeads.Media.AVProVideo;

public class Waypoint : MonoBehaviour {
	
	public GameObject player, w1;
	public GameObject movie, audio;
	private int clickcount = 0;

	// Update is called once per frame
	void Update () {
		//iTween.ScaleFrom (gameObject, new Vector3 (5, 5, 5), 0.5f);
	}

	public void MoveToWaypoint(){
		clickcount = clickcount + 1;
		iTween.MoveTo(player, 
			iTween.Hash (
				"position", w1.transform.position,
				"time", 2, 
				"easetype", "linear",
				"oncomplete", "PlayMedia",
				"oncompletetarget", this.gameObject
			));
	}


	public void PlayMedia(){
		//movie.GetComponent<MoviePlayerSample> ().videoPaused = false;
		if(clickcount <= 1 ) {
			movie.GetComponent<MediaPlayer> ().Play ();
			AudioSource audioSource = audio.GetComponent<AudioSource> ();
			audioSource.Play ();
		}

	}
}
