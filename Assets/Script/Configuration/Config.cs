using System.Collections;
using WindowsInput.Native;
using UnityEngine;

public class Config
{
    public int CaptureMode = 3;
    public int CaptureFPS = 4;
    public bool CaptureDesktop = false;
    public int DesktopIndex = 0;
    public int SpectatorMode = 2;
    public int SpectatorFPS = 2;
    public float SpectatorFOV = 40;
    public float SpectatorSmooth = 0.05f;
    public float[] TPCamPosition = new float[3] { -0.6f, 1.8f, -1.2f };
    public float[] TPCamRotation = new float[3] { 23, 35, 0 };
    public float HandSize = 8f;
    public float HandX = 0;
    public float HandY = 0;
    public float HandZ = 0;
    public float PlayerHeight = 0;
    public int Skybox = 0;
    public float HapticDuration = 0.1f;
    public float HapticAmplitude = 0.75f;
    public int TouchSampleRate  = 2;
    public int HandStabilization = 0;
    public float Threshold = 0.3f;
    public float HandStabilVelocity = 0.3f;
    public float HandStabilDistance = 0.1f;
    public float HandStabilSmooth = 0.1f;
    public bool UseIPCLighting = true;
    public bool UseIPCTouch = true;
    public int TestKeyBind = 40;
    public int ServiceKeyBind = 41;
    public int CoinKeyBind = 31;
    public int CustomKeyBind = 170;
    public bool FlatShadedRing = false;
    public bool PostProcess = true;
    public int AntiAliasing = 0;
    public string batFileLocation = "";

}
