using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataPersistency
{
    public static void deleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public static bool hasStoredPlayerCoords()
    {
        return PlayerPrefs.HasKey("PlayerPosX") && PlayerPrefs.HasKey("PlayerPosY");
    }

    public static void setPlayerCoords(float posX, float posY)
    {
        PlayerPrefs.SetFloat("PlayerPosX", posX);
        PlayerPrefs.SetFloat("PlayerPosY", posY);
    }

    public static float[] getPlayerCoords()
    {
        float[] coords = new float[2];
        coords[0] = PlayerPrefs.GetFloat("PlayerPosX");
        coords[1] = PlayerPrefs.GetFloat("PlayerPosY");
        return coords;
    }

    public static void setCameraCoords(float posX, float posY)
    {
        PlayerPrefs.SetFloat("CameraPosX", posX);
        PlayerPrefs.SetFloat("CameraPosY", posY);
    }

    public static float[] getCameraCoords()
    {
        float[] coords = new float[2];
        coords[0] = PlayerPrefs.GetFloat("CameraPosX");
        coords[1] = PlayerPrefs.GetFloat("CameraPosY");
        return coords;
    }

    public static void setWelcomeFinished(bool b)
    {
        PlayerPrefs.SetInt("isWelcomeFinished", (b ? 1 : 0));
    }

    public static bool isWelcomeFinished()
    {
        return PlayerPrefs.GetInt("isWelcomeFinished") == 1;
    }

    public static void setHutIndex(int i)
    {
        PlayerPrefs.SetInt("CurrentHut", i);
    }

    public static int getHutIndex()
    {
        return PlayerPrefs.GetInt("CurrentHut");
    }

    public static bool inHut()
    {
        return PlayerPrefs.GetInt("CurrentHut") > 0;
    }

    public static void setItemToShowDetailFor(string s)
    {
        PlayerPrefs.SetString("ItemToShowDetailFor", s);
    }

    public static string getItemToShowDetailFor()
    {
        return PlayerPrefs.GetString("ItemToShowDetailFor");
    }

    public static void setTheItemGenre(string s)
    {
        PlayerPrefs.SetString("TheItemGenre", s);
    }

    public static string getTheItemGenre()
    {
        return PlayerPrefs.GetString("TheItemGenre");
    }

    public static void setPriorBPScene(string s)
    {
        PlayerPrefs.SetString("PriorBPScene", s);
    }

    public static string getPriorBPScene()
    {
        return PlayerPrefs.GetString("PriorBPScene");
    }

    public static void setcurrentlyInGameWorld(bool b)
    {
        PlayerPrefs.SetInt("currentlyInGameWorld", (b ? 1 : 0));
    }

    public static bool getcurrentlyInGameWorld()
    {
        return PlayerPrefs.GetInt("currentlyInGameWorld") == 1;
    }
}
