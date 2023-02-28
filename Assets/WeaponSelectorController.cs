using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectorController : MonoBehaviour
{
    public Sprite moodlePage;
    public Sprite googlePage;
    public Sprite googlePageUnavailable;
    public Sprite youtubePage;
    public Sprite youtubePageUnavailable;
    public Sprite stackOverflowPage;
    public Sprite stackOverflowPageUnavailable;
    public Sprite chatgptPage;
    public Sprite chatgptPageUnavailable;

    public GameObject playerObject;
    public GameObject screenImage;
    private void Start()
    {
        setMoodleActive();
        
    }

    public void setMoodleActive()
    {
        screenImage.GetComponent<Image>().sprite = moodlePage;
        playerObject.GetComponent<gunController>().weaponType = 0;
    }

    public void setGoogleActive()
    {
        if (playerObject.GetComponent<PlayerController>().smgUnlocked)
        {
            screenImage.GetComponent<Image>().sprite = googlePage;
            playerObject.GetComponent<gunController>().weaponType = 1;
        }
        else
        {
            screenImage.GetComponent<Image>().sprite = googlePageUnavailable;
        }
    }

    public void setYoutubeActive()
    {
        if (playerObject.GetComponent<PlayerController>().shotgunUnlocked)
        {
            screenImage.GetComponent<Image>().sprite = youtubePage;
            playerObject.GetComponent<gunController>().weaponType = 2;
        }
        else
        {
            screenImage.GetComponent<Image>().sprite = youtubePageUnavailable;
        }
    }

    public void setStackOverflowActive()
    {
        if (playerObject.GetComponent<PlayerController>().sniperUnlocked)
        {
            screenImage.GetComponent<Image>().sprite = stackOverflowPage;
            playerObject.GetComponent<gunController>().weaponType = 3;
        }
        else
        {
            screenImage.GetComponent<Image>().sprite = stackOverflowPageUnavailable;
        }
    }

    public void setChatgptActive()
    {
        if (playerObject.GetComponent<PlayerController>().mgUnlocked)
        {
            screenImage.GetComponent<Image>().sprite = chatgptPage;
            playerObject.GetComponent<gunController>().weaponType = 4;
        }
        else
        {
            screenImage.GetComponent<Image>().sprite =chatgptPageUnavailable;
        }
    }
}
