using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    [SerializeField] private Transform coinTransform;
    [SerializeField] private AudioSource coinSFX, coinMusic;
    [SerializeField] private AudioClip orelClip, reshkaClip;
    [SerializeField] private Animator animator;
    public bool isFlipping = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isFlipping = !isFlipping;

            if (isFlipping)
            {
                animator.SetBool("IsFlipping", true);
                animator.Play("CoinFlip", 0, 0);
                coinMusic.Play();
            } else
            {
                animator.SetBool("IsFlipping", false);
                float coinSide = Random.Range(0, 101);
                Debug.Log(coinSide);
                if(coinSide > FakeChances.ReshkaChances)
                {
                    coinTransform.rotation = Quaternion.Euler(0, coinTransform.rotation.y, coinTransform.rotation.z);
                    coinSFX.clip = orelClip;
                } else
                {
                    coinTransform.rotation = Quaternion.Euler(180, coinTransform.rotation.y, coinTransform.rotation.z);
                    coinSFX.clip = reshkaClip;
                }
                coinSFX.Play();
                coinMusic.Stop();
            }
        }
    }
}
