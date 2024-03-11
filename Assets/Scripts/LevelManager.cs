using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [SerializeField]
    private TMP_Text blueDiamond;
    private int blueDiamoundsCollected;

    [SerializeField]
    private Animator blueDiamoundAnimator;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        blueDiamond.text = blueDiamoundsCollected.ToString();
    }

    public void BlueDiamondCollected()
    {
        blueDiamoundsCollected++;
        blueDiamond.text = blueDiamoundsCollected.ToString();

        blueDiamoundAnimator.SetTrigger("Pop");
    }


}
