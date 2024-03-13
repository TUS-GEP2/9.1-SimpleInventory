using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [SerializeField]
    private TMP_Text blueDiamondTMP;
    private int blueDiamoundsCollected;

    [SerializeField]
    private TMP_Text yellowDiamondTMP;
    private int yellowDiamondsCollected;

    [SerializeField]
    private Animator blueDiamoundAnimator;

    [SerializeField]
    private Animator yellowDiamondAnimator;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        blueDiamondTMP.text = blueDiamoundsCollected.ToString();
    }

    public void BlueDiamondCollected()
    {
        blueDiamoundsCollected++;
        blueDiamondTMP.text = blueDiamoundsCollected.ToString();

        blueDiamoundAnimator.SetTrigger("Pop");
    }

    public void YellowDiamondCollected()
    {
        yellowDiamondsCollected++;
        yellowDiamondTMP.text = yellowDiamondsCollected.ToString();

        yellowDiamondAnimator.SetTrigger("Pop");
    }


}
