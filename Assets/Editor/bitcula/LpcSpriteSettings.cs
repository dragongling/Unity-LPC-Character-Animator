using UnityEngine;
using UnityEditor;
using System.Collections;

public class LpcSpriteSettings : Object
{

    // Animations in LPC Sprite Sheets do have various number of
    // frames per animation. This Setting determines if empty
    // frames should be imported.
    private const bool ImportEmptySpritesInit = false;
    private const string ImportEmptySprites = "LpcSS_ImportEmptySprites";

    private const bool ExpertModeInit = false;
    private const string ExpertMode = "LpcSS_ExpertMode";
    private const int ColCountInit = 13;
    private const string ColCount = "LpcSS_ColCount";
    private const int RowCountInit = 21;
    private const string RowCount = "LpcSS_RowCount";
    private const int PixelsPerUnitInit = 100;
    private const string PixelsPerUnit = "LpcSS_PixelsPerUnit";
    /* Animation Frames */
    private const int ScFrameCountInit = 7;     // Spellcast animation frames
    private const string ScFrameCount = "LpcSS_ScFrameCount";
    private const int ThFrameCountInit = 8;     // Thrust animation frames
    private const string ThFrameCount = "LpcSS_ThFrameCount";
    private const int WcFrameCountInit = 9;     // Walkcycle animation frames
    private const string WcFrameCount = "LpcSS_WcFrameCount";
    private const int SlFrameCountInit = 6;     // Slash animation frames
    private const string SlFrameCount = "LpcSS_SlFrameCount";
    private const int ShFrameCountInit = 13;    // Shoot animation frames
    private const string ShFrameCount = "LpcSS_ShFrameCount";
    private const int HuFrameCountInit = 6;     // Hurt animation frames
    private const string HuFrameCount = "LpcSS_HuFrameCount";


    public static void RestoreInitialValues()
    {
        SetImportEmptySprites(ImportEmptySpritesInit);
        SetExpertMode(ExpertModeInit);
        SetPixelsPerUnit(PixelsPerUnitInit);
        SetColCount(ColCountInit);
        SetRowCount(RowCountInit);
        // Animation Frame Counts
        SetScFrameCount(ScFrameCountInit);
        SetThFrameCount(ThFrameCountInit);
        SetWcFrameCount(WcFrameCountInit);
        SetSlFrameCount(SlFrameCountInit);
        SetShFrameCount(ShFrameCountInit);
        SetHuFrameCount(HuFrameCountInit);
    }

    /* Getter */
    public static bool GetImportEmptySprites()
    {
        return EditorPrefs.HasKey(ImportEmptySprites) && EditorPrefs.GetBool(ImportEmptySprites);
    }

    public static bool GetExpertMode()
    {
        return EditorPrefs.HasKey(ExpertMode) && EditorPrefs.GetBool(ExpertMode);
    }

    public static int GetColCount()
    {
        return EditorPrefs.HasKey(ColCount) ? EditorPrefs.GetInt(ColCount) : ColCountInit;
    }

    public static int GetRowCount()
    {
        return EditorPrefs.HasKey(RowCount) ? EditorPrefs.GetInt(RowCount) : RowCountInit;
    }

    public static int GetPixelsPerUnit()
    {
        return EditorPrefs.HasKey(PixelsPerUnit) ? EditorPrefs.GetInt(PixelsPerUnit) : PixelsPerUnitInit;
    }

    /* Animation Frame Count Getter */
    public static int GetScFrameCount()
    {
        return EditorPrefs.HasKey(ScFrameCount) ? EditorPrefs.GetInt(ScFrameCount) : ScFrameCountInit;
    }

    public static int GetThFrameCount()
    {
        return EditorPrefs.HasKey(ThFrameCount) ? EditorPrefs.GetInt(ThFrameCount) : ThFrameCountInit;
    }

    public static int GetWcFrameCount()
    {
        return EditorPrefs.HasKey(WcFrameCount) ? EditorPrefs.GetInt(WcFrameCount) : WcFrameCountInit;
    }

    public static int GetSlFrameCount()
    {
        return EditorPrefs.HasKey(SlFrameCount) ? EditorPrefs.GetInt(SlFrameCount) : SlFrameCountInit;
    }

    public static int GetShFrameCount()
    {
        return EditorPrefs.HasKey(ShFrameCount) ? EditorPrefs.GetInt(ShFrameCount) : ShFrameCountInit;
    }

    public static int GetHuFrameCount()
    {
        return EditorPrefs.HasKey(HuFrameCount) ? EditorPrefs.GetInt(HuFrameCount) : HuFrameCountInit;
    }

    /* Setter */
    public static void SetImportEmptySprites(bool importEmptySprites)
    {
        EditorPrefs.SetBool(ImportEmptySprites, importEmptySprites);
    }

    public static void SetExpertMode(bool expertMode)
    {
        EditorPrefs.SetBool(ExpertMode, expertMode);
    }

    public static void SetColCount(int cols)
    {
        EditorPrefs.SetInt(ColCount, cols);
    }

    public static void SetRowCount(int rows)
    {
        EditorPrefs.SetInt(RowCount, rows);
    }

    public static void SetPixelsPerUnit(int ppu)
    {
        EditorPrefs.SetInt(PixelsPerUnit, ppu);
    }

    /* Animation Frame Count Setter */
    public static void SetScFrameCount(int frames)
    {
        EditorPrefs.SetInt(ScFrameCount, frames);
    }

    public static void SetThFrameCount(int frames)
    {
        EditorPrefs.SetInt(ThFrameCount, frames);
    }

    public static void SetWcFrameCount(int frames)
    {
        EditorPrefs.SetInt(WcFrameCount, frames);
    }

    public static void SetSlFrameCount(int frames)
    {
        EditorPrefs.SetInt(SlFrameCount, frames);
    }

    public static void SetShFrameCount(int frames)
    {
        EditorPrefs.SetInt(ShFrameCount, frames);
    }

    public static void SetHuFrameCount(int frames)
    {
        EditorPrefs.SetInt(HuFrameCount, frames);
    }
}
