using UnityEngine;
using HutongGames.PlayMaker;
using MSCLoader;

namespace TommoJProductions.CursorMod
{
    public class CursorMod : Mod
    {
        // Started, 06.11.2022

        public override string ID => "CursorMod";
        public override string Name => "Cursor Toggle Mod";
        public override string Author => "tommojphillips";
        public override string Version => VersionInfo.version;
        public override string Description => "Adds a keybind to toggle the cursor ingame. (default key is mouse scroll wheel button)";

        private Keybind cursorToggleKeybindPrimary;
        private Keybind cursorToggleKeybindSecondary;

        private FsmBool playerInMenu;

        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, onLoad);
            SetupFunction(Setup.Update, update);
        }

        private void onLoad()
        {
            playerInMenu = PlayMakerGlobals.Instance.Variables.FindFsmBool("PlayerInMenu");
        }

        private void update()
        {
            cursorFunction();
        }

        public override void ModSettings()
        {
            cursorToggleKeybindPrimary = Keybind.Add(this, "CursorToggle1", "Cursor Toggle Primary", KeyCode.Mouse2);
            cursorToggleKeybindSecondary = Keybind.Add(this, "CursorToggle2", "Cursor Toggle Secondary", KeyCode.None);
        }

        private void cursorFunction()
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(2))
            {
                playerInMenu.Value = !playerInMenu.Value;
            }
        }
    }
}
