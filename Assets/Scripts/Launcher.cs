using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour {

	public GameObject floor;
	public GameObject canvas;
	public GameObject display1, display2, display3, display4, display5, info, d1, wp1, d2, wp2, d3, wp3, d4, wp4, d5, wp5;
	public Material skyboxMat;

	public void Launch () {

		//SceneManager.LoadScene ("Opening");
		RenderSettings.skybox = skyboxMat;
		floor.SetActive (true);
		display1.SetActive (true);
		display2.SetActive (true);
		display3.SetActive (true);
		display4.SetActive (true);
		display5.SetActive (true);
		d1.SetActive (true);
		wp1.SetActive (true);
		d2.SetActive (true);
		wp2.SetActive (true);
		d3.SetActive (true);
		wp3.SetActive (true);
		d4.SetActive (true);
		wp4.SetActive (true);
		d5.SetActive (true);
		wp5.SetActive (true);
		info.SetActive (true);
		Destroy (canvas);
	}

}

