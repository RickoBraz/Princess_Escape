using UnityEngine;
using System.Collections;

public class GoScene : MonoBehaviour {

    public void ChangeScene(string scene)
    {
        Application.LoadLevel(scene);

    }

    public void Fechar() {
        Application.Quit();
    }
}
