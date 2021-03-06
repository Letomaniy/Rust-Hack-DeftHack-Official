﻿using UnityEngine;

internal class HukHealth : MonoBehaviour
{
    public static Texture2D merr10;
    public static Texture2D merr9;
    public static Texture2D merr8;
    public static Texture2D merr7;
    public static Texture2D merr6;
    public static Texture2D merr5;
    public static Texture2D merr4;
    public static Texture2D merr3;
    public static Texture2D merr2;
    public static Texture2D merr1;
    public static Texture2D merr;
    public static Texture2D merr0;
    public static Texture2D black;
    public static Texture2D remen;

    private void Start()
    {

        if (remen == null)
        {
            remen = new Texture2D(1, 1);
            byte[] rawData = {

          0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x08, 0x06, 0x00, 0x00, 0x00, 0xC4, 0xE9, 0x85, 0x63, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x35, 0x49, 0x44, 0x41, 0x54, 0x48, 0x4B, 0xED, 0xCD, 0xB1, 0x0D, 0x00, 0x30, 0x0C, 0xC3, 0x30, 0xA7, 0xFF, 0xFF, 0x9C, 0x74, 0xE8, 0x03, 0x1A, 0xB2, 0x14, 0x22, 0x60, 0x78, 0x54, 0x25, 0xE9, 0xBB, 0x55, 0xE7, 0xFD, 0x2A, 0x23, 0x88, 0x11, 0xC4, 0x08, 0x62, 0x04, 0x31, 0x82, 0x18, 0x41, 0x8C, 0x20, 0xBF, 0x44, 0x92, 0x01, 0xD0, 0x2F, 0x01, 0x31, 0x78, 0xEE, 0x5A, 0x41, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82

            };
            if (!ImageConversion.LoadImage(remen, rawData))
            {
                return;
            }
        }
        if (black == null)
        {
            black = new Texture2D(1, 1);
            byte[] rawData = {

          0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x08, 0x06, 0x00, 0x00, 0x00, 0xC4, 0xE9, 0x85, 0x63, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x35, 0x49, 0x44, 0x41, 0x54, 0x48, 0x4B, 0xED, 0xCD, 0xB1, 0x0D, 0x00, 0x30, 0x0C, 0xC3, 0x30, 0xA7, 0xFF, 0xFF, 0x9C, 0x74, 0xE8, 0x03, 0x1A, 0xB2, 0x14, 0x22, 0x60, 0x78, 0x54, 0x25, 0xE9, 0xBB, 0x55, 0xE7, 0xFD, 0x2A, 0x23, 0x88, 0x11, 0xC4, 0x08, 0x62, 0x04, 0x31, 0x82, 0x18, 0x41, 0x8C, 0x20, 0xBF, 0x44, 0x92, 0x01, 0xD0, 0x2F, 0x01, 0x31, 0x78, 0xEE, 0x5A, 0x41, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(black, rawData))
            {
                return;
            }
        }
        if (merr0 == null)
        {
            merr0 = new Texture2D(1, 1);
            byte[] rawData = {

            0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x08, 0x06, 0x00, 0x00, 0x00, 0xC4, 0xE9, 0x85, 0x63, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x32, 0x49, 0x44, 0x41, 0x54, 0x48, 0x4B, 0xED, 0xCD, 0xA1, 0x11, 0x00, 0x40, 0x08, 0xC4, 0xC0, 0xE3, 0xFB, 0xEF, 0x19, 0xCC, 0x37, 0x10, 0x81, 0x61, 0xB2, 0x26, 0x32, 0x95, 0x74, 0x67, 0xD9, 0xFB, 0x5D, 0xE5, 0x04, 0x71, 0x82, 0x38, 0x41, 0x9C, 0x20, 0x4E, 0x10, 0x27, 0x88, 0x13, 0xE4, 0xCA, 0x24, 0x19, 0xA0, 0xEB, 0x02, 0x30, 0x23, 0x88, 0xB3, 0x39, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr0, rawData))
            {
                return;
            }
        }
        if (merr == null)
        {
            merr = new Texture2D(1, 1);
            byte[] rawData = {

             0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x08, 0x06, 0x00, 0x00, 0x00, 0xC4, 0xE9, 0x85, 0x63, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x33, 0x49, 0x44, 0x41, 0x54, 0x48, 0x4B, 0xED, 0xCD, 0xA1, 0x11, 0x00, 0x30, 0x0C, 0xC3, 0x40, 0xA7, 0xFB, 0xEF, 0x9C, 0x14, 0x74, 0x01, 0x81, 0x90, 0x9E, 0xDE, 0xC0, 0x50, 0x95, 0xBE, 0x5B, 0x76, 0xDE, 0xAF, 0x32, 0x82, 0x18, 0x41, 0x8C, 0x20, 0x46, 0x10, 0x23, 0x88, 0x11, 0xC4, 0x08, 0xF2, 0x4B, 0x24, 0x19, 0xA1, 0xEA, 0x02, 0x30, 0xB1, 0x8F, 0xE7, 0xD2, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr, rawData))
            {
                return;
            }
        }
        if (merr1 == null)
        {
            merr1 = new Texture2D(1, 1);
            byte[] rawData = {

               0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x19, 0x08, 0x06, 0x00, 0x00, 0x00, 0xC4, 0xE9, 0x85, 0x63, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x32, 0x49, 0x44, 0x41, 0x54, 0x48, 0x4B, 0xED, 0xCD, 0xA1, 0x15, 0x00, 0x20, 0x0C, 0xC4, 0xD0, 0x2B, 0xFB, 0xEF, 0xDC, 0x22, 0x58, 0x20, 0xA2, 0x86, 0x97, 0x6F, 0x22, 0x53, 0x7D, 0x65, 0xD9, 0x79, 0x5D, 0xE5, 0x04, 0x71, 0x82, 0x38, 0x41, 0x9C, 0x20, 0x4E, 0x10, 0x27, 0x88, 0x13, 0xE4, 0x97, 0x49, 0x32, 0x45, 0x60, 0x04, 0x2E, 0x19, 0xA3, 0xC7, 0x89, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr1, rawData))
            {
                return;
            }
        }
        if (merr10 == null)
        {
            merr10 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0xE1, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0xF9, 0x02, 0x2F, 0xD3, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0xB7, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xED, 0xD3, 0x31, 0x0A, 0xC3, 0x30, 0x10, 0x00, 0x41, 0x39, 0xF9, 0xFF, 0x97, 0xA3, 0xD8, 0x45, 0xC0, 0xA8, 0x70, 0x67, 0x36, 0x09, 0x33, 0x70, 0x88, 0xC3, 0x57, 0x19, 0x76, 0x9B, 0xCF, 0x31, 0xC7, 0x36, 0xC6, 0x78, 0x9C, 0xE6, 0xBC, 0x5F, 0x7D, 0x5B, 0xF7, 0x5F, 0xBB, 0x5D, 0xF7, 0x7F, 0xBE, 0x5D, 0xF7, 0x1B, 0x6E, 0x5F, 0xFB, 0x33, 0xF7, 0x39, 0xDE, 0xCF, 0x5C, 0xED, 0x77, 0xDD, 0xAE, 0xFB, 0xB7, 0xDF, 0x1E, 0xBF, 0x10, 0x08, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x62, 0x22, 0x84, 0x98, 0x08, 0x21, 0x26, 0x42, 0x88, 0x89, 0x10, 0x52, 0x63, 0xBC, 0x01, 0x1F, 0xB6, 0x50, 0xC4, 0xCB, 0x5C, 0x22, 0x79, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr10, rawData))
            {
                return;
            }
        }
        if (merr9 == null)
        {
            merr9 = new Texture2D(1, 1);
            byte[] rawData = {
                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0xC8, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0x4A, 0x4A, 0x07, 0xC9, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0xAD, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xED, 0xD3, 0x31, 0x0A, 0xC3, 0x30, 0x10, 0x00, 0x41, 0x39, 0xF9, 0xFF, 0x97, 0xA3, 0xD8, 0x45, 0xC0, 0x08, 0xBC, 0x4D, 0x70, 0x91, 0x30, 0x03, 0x87, 0x38, 0x7C, 0x8D, 0x8B, 0xDD, 0xE6, 0x73, 0xCC, 0xB1, 0x8D, 0x31, 0x1E, 0xA7, 0x39, 0xEF, 0xF5, 0x6D, 0xDD, 0x7F, 0xED, 0x76, 0xDD, 0xFF, 0xF9, 0x76, 0xDD, 0x6F, 0xB8, 0x7D, 0xED, 0xCF, 0xDC, 0xE7, 0x78, 0x3F, 0x53, 0xFB, 0x5D, 0xB7, 0xEB, 0xFE, 0xCD, 0xED, 0xF1, 0x7B, 0xC0, 0x05, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0x40, 0x10, 0x08, 0x04, 0x81, 0xC0, 0xA5, 0x31, 0xDE, 0x2E, 0x65, 0x37, 0xEF, 0x83, 0xF6, 0x1B, 0x86, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82

            };
            if (!ImageConversion.LoadImage(merr9, rawData))
            {
                return;
            }
        }
        if (merr8 == null)
        {
            merr8 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0xAF, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0x79, 0x71, 0x18, 0xC0, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0xAD, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xED, 0xD2, 0x31, 0x0A, 0xC3, 0x40, 0x0C, 0x00, 0x41, 0x39, 0xF9, 0xFF, 0x97, 0x73, 0xB1, 0x8B, 0x80, 0x71, 0xE1, 0x26, 0xA4, 0xD8, 0x30, 0x03, 0xE2, 0x10, 0x16, 0xB8, 0xD9, 0x6D, 0x3D, 0x67, 0xCD, 0x36, 0x33, 0x8F, 0xD3, 0x9C, 0xF7, 0xBB, 0x6F, 0xD7, 0xBD, 0x76, 0x7B, 0xDD, 0xFF, 0xF9, 0xF6, 0xBA, 0xFF, 0xE0, 0xF6, 0xB5, 0x3F, 0x6B, 0x9F, 0xE3, 0xFD, 0xCC, 0xDD, 0xFE, 0xED, 0xED, 0xF1, 0x6B, 0x48, 0x12, 0x2F, 0x59, 0xE2, 0x25, 0x4B, 0xBC, 0x64, 0x89, 0x97, 0x2C, 0xF1, 0x92, 0x25, 0x5E, 0xB2, 0xC4, 0x4B, 0x96, 0x78, 0xC9, 0x12, 0x2F, 0x59, 0xE2, 0x25, 0x4B, 0xBC, 0x64, 0x89, 0x97, 0x2C, 0xF1, 0x92, 0x25, 0x5E, 0xB2, 0xC4, 0x4B, 0x96, 0x78, 0xC9, 0x12, 0x2F, 0x59, 0xE2, 0x25, 0x4B, 0xBC, 0x64, 0x89, 0x97, 0x2C, 0xF1, 0x92, 0x25, 0x5E, 0xB2, 0xC4, 0x4B, 0x96, 0x78, 0xC9, 0x12, 0x2F, 0x59, 0xE2, 0x25, 0x4B, 0xBC, 0x64, 0x89, 0x97, 0x2C, 0xF1, 0x92, 0x25, 0x5E, 0xB2, 0xC4, 0x4B, 0x96, 0x78, 0xC9, 0x12, 0x2F, 0x59, 0xE2, 0x25, 0x4B, 0xBC, 0x64, 0x89, 0x97, 0x2C, 0xF1, 0x12, 0x35, 0xF3, 0x06, 0xB7, 0x7B, 0x1F, 0x1B, 0x35, 0x70, 0x4F, 0x36, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr8, rawData))
            {
                return;
            }
        }
        if (merr7 == null)
        {
            merr7 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x96, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0xED, 0x97, 0xB1, 0x32, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0xA1, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xED, 0xD2, 0x31, 0x0E, 0xC2, 0x30, 0x10, 0x00, 0xC1, 0x0B, 0xFC, 0xFF, 0xCB, 0x98, 0xA4, 0x8B, 0x5C, 0x50, 0xB1, 0x05, 0x68, 0x46, 0xB2, 0xAC, 0xB3, 0xAF, 0xDC, 0x63, 0x3D, 0x67, 0xCD, 0x31, 0x33, 0x8F, 0xDB, 0xB9, 0xCF, 0x9F, 0xFE, 0xF6, 0xF9, 0xD7, 0x76, 0xF7, 0xF9, 0x9F, 0x77, 0xF7, 0x39, 0xD8, 0x7D, 0x9D, 0xD7, 0x3A, 0xCF, 0x75, 0x5F, 0xCF, 0xF0, 0x75, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x21, 0x2C, 0x12, 0xC2, 0x22, 0x30, 0xF3, 0x06, 0xDB, 0xF8, 0x06, 0x46, 0x08, 0xDE, 0x26, 0xAA, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr7, rawData))
            {
                return;
            }
        }
        if (merr6 == null)
        {
            merr6 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x7D, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0x22, 0x95, 0x47, 0xB4, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x8B, 0x49, 0x44, 0x41, 0x54, 0x78, 0x5E, 0xED, 0xD1, 0x31, 0x0A, 0x80, 0x30, 0x14, 0x05, 0xC1, 0xAF, 0xDE, 0xFF, 0xCC, 0x8A, 0x5D, 0xB0, 0xB0, 0xD7, 0x9D, 0x81, 0x40, 0x1E, 0x49, 0xB7, 0xDB, 0x79, 0xCC, 0x39, 0xDB, 0xCC, 0xEC, 0xCB, 0x59, 0xF7, 0xDB, 0xDB, 0x73, 0x7F, 0xED, 0xEF, 0x73, 0xFF, 0xF9, 0xEF, 0xB2, 0xEF, 0x2B, 0x31, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0x07, 0x89, 0x1E, 0x24, 0x7A, 0x90, 0xE8, 0x41, 0xA2, 0xE7, 0xCC, 0x5C, 0xE1, 0xE5, 0x03, 0x25, 0xB9, 0x27, 0xD0, 0x5E, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr6, rawData))
            {
                return;
            }
        }
        if (merr5 == null)
        {
            merr5 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0xF9, 0x2E, 0xED, 0x96, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x89, 0x49, 0x44, 0x41, 0x54, 0x68, 0x43, 0xED, 0xD1, 0x41, 0x0A, 0x80, 0x30, 0x0C, 0x00, 0xC1, 0x54, 0xFF, 0xFF, 0xE6, 0x8A, 0x37, 0xF1, 0xE0, 0x79, 0x84, 0x1D, 0x28, 0x25, 0x24, 0xB7, 0x5D, 0xFB, 0x9C, 0x3D, 0x6B, 0x66, 0x8E, 0xC7, 0x7B, 0xCE, 0x5F, 0xBB, 0xF7, 0xFC, 0xB7, 0xDB, 0xF7, 0x0C, 0xDC, 0xDE, 0x5F, 0x20, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xC1, 0x14, 0x04, 0x53, 0x10, 0x4C, 0x41, 0x30, 0x05, 0xA1, 0xCC, 0x5C, 0x42, 0xB1, 0x02, 0xFA, 0x04, 0xF1, 0xA1, 0xAA, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr5, rawData))
            {
                return;
            }
        }
        if (merr4 == null)
        {
            merr4 = new Texture2D(1, 1);
            byte[] rawData = {
                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x4B, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0x47, 0x78, 0xB5, 0xCB, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x82, 0x49, 0x44, 0x41, 0x54, 0x68, 0x43, 0xED, 0xD0, 0x31, 0x0A, 0x80, 0x40, 0x0C, 0x00, 0xC1, 0xA8, 0xFF, 0x7F, 0xB3, 0x62, 0x27, 0x16, 0xEA, 0x96, 0xC2, 0x0C, 0x1C, 0x47, 0x48, 0xAA, 0x5D, 0xF6, 0x6D, 0xF6, 0x59, 0x66, 0x66, 0xBD, 0xBC, 0xEB, 0xFC, 0xB4, 0xBB, 0xCF, 0x7F, 0xBB, 0xBD, 0xCF, 0x2F, 0xB7, 0xE7, 0xC7, 0x47, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x05, 0x62, 0x7D, 0x36, 0x73, 0x00, 0xB1, 0x29, 0x02, 0xCF, 0x0E, 0xF8, 0x9C, 0x1A, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82

            };
            if (!ImageConversion.LoadImage(merr4, rawData))
            {
                return;
            }
        }
        if (merr3 == null)
        {
            merr3 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0x4D, 0x24, 0x1B, 0x99, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x5B, 0x49, 0x44, 0x41, 0x54, 0x58, 0x47, 0xED, 0xCF, 0x31, 0x0A, 0x00, 0x20, 0x0C, 0xC5, 0xD0, 0xAF, 0xDE, 0xFF, 0xCC, 0x8A, 0x5B, 0x71, 0x70, 0x35, 0x48, 0x1E, 0x14, 0x29, 0x75, 0x49, 0x9B, 0x23, 0x33, 0x2D, 0x49, 0x2F, 0x53, 0xF7, 0xDB, 0xED, 0xDC, 0x1F, 0xFE, 0xDD, 0xCF, 0x17, 0x0C, 0xA1, 0x31, 0x84, 0xC6, 0x10, 0x1A, 0x43, 0x68, 0x0C, 0xA1, 0x31, 0x84, 0xC6, 0x10, 0x1A, 0x43, 0x68, 0x0C, 0xA1, 0x31, 0x84, 0xC6, 0x10, 0x1A, 0x43, 0x68, 0x0C, 0xA1, 0x31, 0x84, 0xC6, 0x10, 0x1A, 0x43, 0x68, 0x0C, 0xA1, 0x31, 0x84, 0xE6, 0x93, 0x90, 0x64, 0x01, 0x0F, 0x96, 0x02, 0xA3, 0xCB, 0x33, 0xAF, 0x38, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr3, rawData))
            {
                return;
            }
        }
        if (merr2 == null)
        {
            merr2 = new Texture2D(1, 1);
            byte[] rawData = {

                0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x19, 0x00, 0x00, 0x00, 0x27, 0x08, 0x06, 0x00, 0x00, 0x00, 0xFA, 0x99, 0xE3, 0xBE, 0x00, 0x00, 0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC, 0x61, 0x05, 0x00, 0x00, 0x00, 0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E, 0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0x49, 0x49, 0x44, 0x41, 0x54, 0x58, 0x47, 0xED, 0xCD, 0x31, 0x0A, 0x00, 0x20, 0x0C, 0xC5, 0xD0, 0xAF, 0xDE, 0xFF, 0xCC, 0x8A, 0x9B, 0x08, 0x0A, 0x19, 0x74, 0x4A, 0xA0, 0xD0, 0xD2, 0xE1, 0x95, 0xDE, 0xD2, 0x53, 0x92, 0xD4, 0x65, 0xD6, 0xFB, 0xF6, 0xDB, 0xEF, 0xC3, 0x6F, 0xAE, 0xCF, 0x13, 0x41, 0x89, 0xA0, 0x44, 0x50, 0x22, 0x28, 0x11, 0x94, 0x08, 0x4A, 0x04, 0x25, 0x82, 0x12, 0x41, 0x89, 0xA0, 0x44, 0x50, 0x22, 0xA8, 0x0F, 0x48, 0x32, 0x00, 0xA8, 0x60, 0x02, 0x78, 0x15, 0x5D, 0x18, 0xD1, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
            };
            if (!ImageConversion.LoadImage(merr2, rawData))
            {
                return;
            }
        }

    }
}
