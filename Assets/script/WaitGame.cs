
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitGame : MonoBehaviour
{
    public void BtnOnClick()
    {
        SceneManager.LoadScene("finish");
    }
}
