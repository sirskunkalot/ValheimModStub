// ValheimModStub
// a Valheim mod skeleton
// 
// File:    ValheimModStub.cs
// Project: ValheimModStub

using BepInEx;
using HarmonyLib;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using ValheimMod.UnityWrappers;

namespace ValheimModStub
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    internal class ValheimModStubPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.bepinex.plugins.ValheimModStub";
        public const string PluginName = "ValheimModStub";
        public const string PluginVersion = "0.0.1";

        private Harmony m_harmony;
        
        private void Awake()
        {
            // Create harmony patches
            m_harmony = new Harmony(PluginGUID);
            m_harmony.PatchAll();

            // Make sure the references for the Unity wrappers are loaded
            Assembly.GetAssembly(typeof(ItemDropWrapper));
        }

#if DEBUG
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F6))
            { // Set a breakpoint here to break on F6 key press
            }
        }
#endif

        private void OnDestroy()
        {
            // Remove harmony patches
            m_harmony.UnpatchAll(PluginGUID);
        }

        private void OnGUI()
        {
            // Display version in main menu
            if (SceneManager.GetActiveScene().name == "start")
            {
                GUI.Label(new Rect(Screen.width - PluginName.Length * 11, 5, PluginName.Length * 11, 25), $"{PluginName} v{PluginVersion}");
            }
        }
    }
}