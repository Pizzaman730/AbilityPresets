using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BoplFixedMath;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
//using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
//using BattleLib;

namespace AbilityPresets
{  
    [BepInPlugin("com.PizzaMan730.AbilityPresets", "AbilityPresets", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigFile config;
        private ConfigEntry<int> Preset1_1;
        private ConfigEntry<int> Preset1_2;
        private ConfigEntry<int> Preset1_3;
        private ConfigEntry<int> Preset2_1;
        private ConfigEntry<int> Preset2_2;
        private ConfigEntry<int> Preset2_3;
        private ConfigEntry<int> Preset3_1;
        private ConfigEntry<int> Preset3_2;
        private ConfigEntry<int> Preset3_3;
        private ConfigEntry<int> Preset4_1;
        private ConfigEntry<int> Preset4_2;
        private ConfigEntry<int> Preset4_3;
        private ConfigEntry<int> Preset5_1;
        private ConfigEntry<int> Preset5_2;
        private ConfigEntry<int> Preset5_3;
        private ConfigEntry<int> Preset6_1;
        private ConfigEntry<int> Preset6_2;
        private ConfigEntry<int> Preset6_3;
        private ConfigEntry<int> Preset7_1;
        private ConfigEntry<int> Preset7_2;
        private ConfigEntry<int> Preset7_3;
        private ConfigEntry<int> Preset8_1;
        private ConfigEntry<int> Preset8_2;
        private ConfigEntry<int> Preset8_3;
        private ConfigEntry<int> Preset9_1;
        private ConfigEntry<int> Preset9_2;
        private ConfigEntry<int> Preset9_3;
        private ConfigEntry<int> Preset0_1;
        private ConfigEntry<int> Preset0_2;
        private ConfigEntry<int> Preset0_3;


    
        private void Awake()
        {
            Logger.LogInfo("AbilityPresets has loaded!");


            config = base.Config;
            Preset1_1 = config.Bind("Preset 1", "Slot 1", 0, "");
            Preset1_2 = config.Bind("Preset 1", "Slot 2", 0, "");
            Preset1_3 = config.Bind("Preset 1", "Slot 3", 0, "");

            Preset2_1 = config.Bind("Preset 2", "Slot 1", 0, "");
            Preset2_2 = config.Bind("Preset 2", "Slot 2", 0, "");
            Preset2_3 = config.Bind("Preset 2", "Slot 3", 0, "");

            Preset3_1 = config.Bind("Preset 3", "Slot 1", 0, "");
            Preset3_2 = config.Bind("Preset 3", "Slot 2", 0, "");
            Preset3_3 = config.Bind("Preset 3", "Slot 3", 0, "");

            Preset4_1 = config.Bind("Preset 4", "Slot 1", 0, "");
            Preset4_2 = config.Bind("Preset 4", "Slot 2", 0, "");
            Preset4_3 = config.Bind("Preset 4", "Slot 3", 0, "");

            Preset5_1 = config.Bind("Preset 5", "Slot 1", 0, "");
            Preset5_2 = config.Bind("Preset 5", "Slot 2", 0, "");
            Preset5_3 = config.Bind("Preset 5", "Slot 3", 0, "");

            Preset6_1 = config.Bind("Preset 6", "Slot 1", 0, "");
            Preset6_2 = config.Bind("Preset 6", "Slot 2", 0, "");
            Preset6_3 = config.Bind("Preset 6", "Slot 3", 0, "");

            Preset7_1 = config.Bind("Preset 7", "Slot 1", 0, "");
            Preset7_2 = config.Bind("Preset 7", "Slot 2", 0, "");
            Preset7_3 = config.Bind("Preset 7", "Slot 3", 0, "");

            Preset8_1 = config.Bind("Preset 8", "Slot 1", 0, "");
            Preset8_2 = config.Bind("Preset 8", "Slot 2", 0, "");
            Preset8_3 = config.Bind("Preset 8", "Slot 3", 0, "");

            Preset9_1 = config.Bind("Preset 9", "Slot 1", 0, "");
            Preset9_2 = config.Bind("Preset 9", "Slot 2", 0, "");
            Preset9_3 = config.Bind("Preset 9", "Slot 3", 0, "");

            Preset0_1 = config.Bind("Preset 0", "Slot 1", 0, "");
            Preset0_2 = config.Bind("Preset 0", "Slot 2", 0, "");
            Preset0_3 = config.Bind("Preset 0", "Slot 3", 0, "");
            

            Harmony harmony = new("com.PizzaMan730.AbilityPresets");
        }

        private void Update()
        {
            if (SceneManager.GetActiveScene().name == "ChSelect_online" || SceneManager.GetActiveScene().name == "CharacterSelect")
            {
                bool ctrlIsDown = Keyboard.current[Key.LeftCtrl].isPressed;
                bool oneWasPressedThisFrame = Keyboard.current[Key.Digit1].wasPressedThisFrame;
                if (oneWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset1_1, Preset1_2, Preset1_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset1_1.Value, Preset1_2.Value, Preset1_3.Value);
                    }
                }
                bool twoWasPressedThisFrame = Keyboard.current[Key.Digit2].wasPressedThisFrame;
                if (twoWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset2_1, Preset2_2, Preset2_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset2_1.Value, Preset2_2.Value, Preset2_3.Value);
                    }
                }
                bool threeWasPressedThisFrame = Keyboard.current[Key.Digit3].wasPressedThisFrame;
                if (threeWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset3_1, Preset3_2, Preset3_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset3_1.Value, Preset3_2.Value, Preset3_3.Value);
                    }
                }
                bool fourWasPressedThisFrame = Keyboard.current[Key.Digit4].wasPressedThisFrame;
                if (fourWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset4_1, Preset4_2, Preset4_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset4_1.Value, Preset4_2.Value, Preset4_3.Value);
                    }
                }
                bool fiveWasPressedThisFrame = Keyboard.current[Key.Digit5].wasPressedThisFrame;
                if (fiveWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset5_1, Preset5_2, Preset5_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset5_1.Value, Preset5_2.Value, Preset5_3.Value);
                    }
                }
                bool sixWasPressedThisFrame = Keyboard.current[Key.Digit6].wasPressedThisFrame;
                if (sixWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset6_1, Preset6_2, Preset6_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset6_1.Value, Preset6_2.Value, Preset6_3.Value);
                    }
                }
                bool sevenWasPressedThisFrame = Keyboard.current[Key.Digit7].wasPressedThisFrame;
                if (sevenWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset7_1, Preset7_2, Preset7_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset7_1.Value, Preset7_2.Value, Preset7_3.Value);
                    }
                }
                bool eightWasPressedThisFrame = Keyboard.current[Key.Digit8].wasPressedThisFrame;
                if (eightWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset8_1, Preset8_2, Preset8_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset8_1.Value, Preset8_2.Value, Preset8_3.Value);
                    }
                }
                bool nineWasPressedThisFrame = Keyboard.current[Key.Digit9].wasPressedThisFrame;
                if (nineWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset9_1, Preset9_2, Preset9_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset9_1.Value, Preset9_2.Value, Preset9_3.Value);
                    }
                }
                bool zeroWasPressedThisFrame = Keyboard.current[Key.Digit0].wasPressedThisFrame;
                if (zeroWasPressedThisFrame)
                {
                    if (ctrlIsDown)
                    {   
                        Debug.Log("Saving preset");
                        SavePreset(Preset0_1, Preset0_2, Preset0_3);
                    }
                    else
                    {
                        Debug.Log("Loading preset");
                        LoadPreset(Preset0_1.Value, Preset0_2.Value, Preset0_3.Value);
                    }
                }
                if (GameObject.Find("PresetText")==null)
                {
                    Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
			        GameObject presetText = new GameObject("PresetText", new Type[]
			        {
			        	typeof(RectTransform),
			        	typeof(TextMeshProUGUI)
			        });
			        presetText.transform.SetParent(canvas.transform);
			        TextMeshProUGUI presetTextText = presetText.GetComponent<TextMeshProUGUI>();
			        presetTextText.raycastTarget = false;
			        presetTextText.text = "Press a number key to load that preset\nHold control while pressing to save";
			        presetTextText.color = Color.black;
			        presetTextText.alignment = TextAlignmentOptions.Center;
			        presetTextText.font = LocalizedText.localizationTable.GetFont(Settings.Get().Language, false);
                    presetTextText.fontSize = 20f;
			        RectTransform presetTextBox = presetText.GetComponent<RectTransform>();
			        Rect rect = canvas.GetComponent<RectTransform>().rect;
			        float height = rect.height;
			        float width = rect.width;
                    presetTextBox.anchoredPosition = new Vector2((0f - width)/2f+600f, (0f - height)/2f+100f);
			        presetTextBox.sizeDelta = new Vector2(width, 100f);
			        presetText.SetActive(true);
                }
            }   
        }   

        private void SavePreset(ConfigEntry<int> Preset1, ConfigEntry<int> Preset2, ConfigEntry<int> Preset3)
        {
            Transform selector = GameObject.Find("Rectangle1").transform.FindChild("SELECT_COLOR");
            Preset1.Value = selector.FindChild("ability_TOP").GetComponent<SelectAbility>().SelectedIndex;
            Preset2.Value = selector.FindChild("ability_MID").GetComponent<SelectAbility>().SelectedIndex;
            Preset3.Value = selector.FindChild("ability_BOT").GetComponent<SelectAbility>().SelectedIndex;
        }

        private void LoadPreset(int Preset1, int Preset2, int Preset3)
        {
            Debug.Log("Test");
            Transform selector = GameObject.Find("Rectangle1").transform.FindChild("SELECT_COLOR");
            Debug.Log("Test1");
            selector.FindChild("ability_TOP").GetComponent<SelectAbility>().Select(Preset1);
            selector.FindChild("ability_MID").GetComponent<SelectAbility>().Select(Preset2);
            selector.FindChild("ability_BOT").GetComponent<SelectAbility>().Select(Preset3);
        }
    }
    public enum Abilities
    {
        random,
        dash,
        grenade,
        bow,
        engine,
        blink,
        gust,
        grow,
        rock,
        missile,
        spike,
        time,
        smoke,
        platform,
        revive,
        roll,
        shrink,
        blackhole,
        invisibility,
        meteor,
        macho,
        push,
        tesla,
        mine,
        teleport,
        drill,
        hookshot,
        beam
    }
}

//      dotnet build "C:\Users\ajarc\BoplMods\AbilityPresets\AbilityPresets.csproj"
