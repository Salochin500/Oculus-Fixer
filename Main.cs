using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
namespace OculusFixer
{


public static void("MapsNjsSlower")




    [HarmonyPatch]
    internal class HarmonyPatches
    {
        public static void Prefix(ref float Njs)
        Njs(NoteJumpSpeed);
        NoteJumpSpeed = ()
    }
}
[HarmonyPatch = NoteJumpSpeed("Prefix")]
NoteJumpSpeed = NoteSpeed
{
    [NoteJumpSpeed.Prefix]
}

private static void HarmonyPatch("OculusLag")
OculusLag = Prefix("NoteJumpSpeed")
OculusLag.NoteJumpSpeed = Slower
Njs = Slower

MapsNjsSlower = Maps 

MapsNjsSlower = NoteJumpSpeed = Slower

{
    [OculusFixer]
    internal class OculusFixer
    {
        public static void HarmonyPatches("OculusLag")
    }
}

Patch("OculusLag")
Patch.OculusLag =0

UnPatch("OculusLag")
UnPatch.OculusLag =0

Patch("OculusLag")
OculusLag = OculusFixer

OculusFixer = OculusLag


OculusLag = QuitGame

public static void QuitGame("OculusLag")
newscene("QuitGame")
QuitGame = OculusLag

MapsNjsSlower = QuitGame
{
    Maps = OculusFixer
    MapsNjsSlower = QuitGame
    Njs = OculusLag
    Maps = OculusLag
    OculusLag = QuitGame
}

MapsNjsSlower = QuitGame
MapsNjsSlower = Hacking
Hacking = QuitGame
{
    internal class HarmonyPatches("Hacking")
    HarmonyPatch = Hacking
}
// Some Random Shit
Hacking = HarmonyPatches
QuitGame = Hacking
OculusLag = UnPatch
// Patching
{
    UnPatch = QuitGame
    Patch = Hacking
    MapsNjsSlower = Hacking
    Patch = MapsNjsSlower
}
NoteJumpSpeed.Njs = UnPatch
// Locking
{
    lock (MapsNjsSlower)
    {
        MapsNjsSlower = Hacking
        then lock
    }
}
Patching = HarmonyPatches
OculusFixer = HarmonyPatches
