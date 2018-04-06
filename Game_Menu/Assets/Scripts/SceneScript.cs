using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	public void MenuSwitch(){

		SceneManager.LoadScene (1);

	}

	public void ProfileSwitch(){

		SceneManager.LoadScene (2);

	}

	public void CarsSwitch(){

		SceneManager.LoadScene (3);

	}

	public void UpgradesSwitch(){

		SceneManager.LoadScene (4);

	}

	public void ShopSwitch(){

		SceneManager.LoadScene (5);

	}

	public void SettingSwitch(){

		SceneManager.LoadScene (6);

	}

	public void ViewCarSwitch(){

		SceneManager.LoadScene (7);

	}

	public void StartGameSwitch(){

		SceneManager.LoadScene (8);

	}
		
}