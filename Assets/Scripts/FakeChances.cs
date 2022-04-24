using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FakeChances : MonoBehaviour
{
    [SerializeField] private Slider reshkaSlider;
    public static float ReshkaChances = 50;

    public void GoToChances()
    {
        SceneManager.LoadScene("Chances");
    }

    public void SetChances()
    {
        ReshkaChances = reshkaSlider.value;
        SceneManager.LoadScene("Coin");
    }
}
