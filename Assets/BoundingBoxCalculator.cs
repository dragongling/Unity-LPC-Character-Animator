using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class BoundingBoxCalculator : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        // var sprites = AssetDatabase.LoadAllAssetsAtPath("Assets/Sprites/Standard/Character/body/male/light.png");
        // var sprite = sprites.First() as Sprite;
        
        var texture = new Texture2D(2, 2);
        var filePath = Path.Combine(Application.dataPath, "Sprites/Standard/Character/body/male/light.png");
        // var boundingRect = new RectInt(0, 0, texture.width, texture.height);
        
        if (File.Exists(filePath))
        {
            var fileData = File.ReadAllBytes(filePath);
            texture.LoadImage(fileData);
        }
        else
        {
            Debug.Log("No sprite found");
        }
        var pixels = texture.GetPixels32();
        var boundingBox = GetBoundingBox(pixels, new RectInt(0, 0, 64, 64), texture.width);
        Debug.Log(boundingBox);
        // spriteRenderer.sprite = sprite;
    }

    private static BoundingBox GetBoundingBox(Color32[] pixels, RectInt area, int textureWidth)
    {
        int minX = area.xMax, maxX = area.xMin, minY = area.yMax, maxY = area.yMin;
        var hasColor = false;

        for (var y = area.yMin; y < area.yMax; y++)
        {
            for (var x = area.xMin; x < area.xMax; x++)
            {
                var pixel = pixels[y * textureWidth + x];
                if (pixel.a == 255)  // Assuming alpha > 0 means part of the sprite
                {
                    hasColor = true;
                    if (x < minX) minX = x;
                    if (x > maxX) maxX = x;
                    if (y < minY) minY = y;
                    if (y > maxY) maxY = y;
                }
            }
        }

        return new BoundingBox
        {
            Min = new Vector2Int(minX, minY),
            Max = new Vector2Int(maxX, maxY),
            HasColor = hasColor,
        };
    }

    private struct BoundingBox
    {
        public Vector2Int Min, Max;
        public bool HasColor;
        public override string ToString()
        {
            return !HasColor ? "No color" : $"({Min.x}, {Min.y}, {Max.x}, {Max.y})";
        }
    }
}
