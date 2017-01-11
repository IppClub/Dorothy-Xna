﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Dorothy.Core;

namespace Dorothy.Effects
{
	public class SpriteEffect : Effect, ISpriteEffect
	{
		private EffectParameter _alpha;
		private EffectParameter _world;
		private EffectParameter _view;
		private EffectParameter _projection;
		private EffectParameter _texture;
		private EffectParameter _color;
		private static readonly byte[] _effectCode = new byte[]
        {
            #region ByteCodes
            0xCF, 0x0B, 0xF0, 0xBC, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, 0x09, 0xFF, 0xFE, 0x64, 0x02, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x41, 0x6C, 0x70, 0x68, 0x61, 0x00, 0x97, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x8C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00,
            0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00,
            0x57, 0x6F, 0x72, 0x6C, 0x64, 0x00, 0x97, 0x00, 0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0xF4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x56, 0x69, 0x65, 0x77, 0x00, 0x01, 0x97, 0x00, 0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x5C, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x50, 0x72, 0x6F, 0x6A, 0x65, 0x63, 0x74, 0x69,
            0x6F, 0x6E, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x84, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x54, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0xB8, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x43, 0x6F, 0x6C, 0x6F, 0x72, 0x00, 0x97, 0x00, 0x0A, 0x00, 0x00, 0x00,
            0x04, 0x00, 0x00, 0x00, 0x04, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00,
            0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0xA4, 0x00, 0x00, 0x00,
            0x00, 0x01, 0x00, 0x00, 0xDC, 0x01, 0x00, 0x00, 0xD8, 0x01, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x54, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x53,
            0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x50, 0x61, 0x73, 0x73, 0x30, 0x00, 0x97, 0x00, 0x0B, 0x00, 0x00, 0x00,
            0x54, 0x65, 0x63, 0x68, 0x6E, 0x69, 0x71, 0x75, 0x65, 0x30, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00,
            0x05, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x30, 0x00, 0x00, 0x00,
            0x4C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x98, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x1C, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6C, 0x01, 0x00, 0x00,
            0x80, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x90, 0x01, 0x00, 0x00, 0xAC, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xC4, 0x01, 0x00, 0x00, 0xF0, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x54, 0x02, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x48, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x92, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x1C, 0x02, 0x00, 0x00, 0x18, 0x02, 0x00, 0x00, 0x93, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x34, 0x02, 0x00, 0x00,
            0x30, 0x02, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x98, 0x01, 0x00, 0x00, 0x00, 0x02, 0xFF, 0xFF,
            0xFE, 0xFF, 0x3D, 0x00, 0x43, 0x54, 0x41, 0x42, 0x1C, 0x00, 0x00, 0x00, 0xBF, 0x00, 0x00, 0x00, 0x00, 0x02, 0xFF, 0xFF, 0x03, 0x00, 0x00, 0x00,
            0x1C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0xB8, 0x00, 0x00, 0x00, 0x58, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x60, 0x00, 0x00, 0x00, 0x70, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x02, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x88, 0x00, 0x00, 0x00,
            0x70, 0x00, 0x00, 0x00, 0x98, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0x00, 0x02, 0x00, 0xA8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x41, 0x6C, 0x70, 0x68, 0x61, 0x00, 0xAB, 0xAB, 0x00, 0x00, 0x03, 0x00, 0x01, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x43, 0x6F, 0x6C, 0x6F, 0x72, 0x00, 0xAB, 0xAB,
            0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x54, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x53,
            0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x00, 0xAB, 0x04, 0x00, 0x0C, 0x00, 0x01, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x70, 0x73, 0x5F, 0x32, 0x5F, 0x30, 0x00, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x28, 0x52, 0x29, 0x20, 0x48, 0x4C, 0x53,
            0x4C, 0x20, 0x53, 0x68, 0x61, 0x64, 0x65, 0x72, 0x20, 0x43, 0x6F, 0x6D, 0x70, 0x69, 0x6C, 0x65, 0x72, 0x20, 0x39, 0x2E, 0x32, 0x36, 0x2E, 0x39,
            0x35, 0x32, 0x2E, 0x32, 0x38, 0x34, 0x34, 0x00, 0x51, 0x00, 0x00, 0x05, 0x02, 0x00, 0x0F, 0xA0, 0x00, 0x00, 0x80, 0xBF, 0x00, 0x00, 0x80, 0x3F,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1F, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x03, 0xB0, 0x1F, 0x00, 0x00, 0x02,
            0x00, 0x00, 0x00, 0x90, 0x00, 0x08, 0x0F, 0xA0, 0x42, 0x00, 0x00, 0x03, 0x00, 0x00, 0x0F, 0x80, 0x00, 0x00, 0xE4, 0xB0, 0x00, 0x08, 0xE4, 0xA0,
            0x05, 0x00, 0x00, 0x03, 0x01, 0x00, 0x08, 0x80, 0x00, 0x00, 0xFF, 0x80, 0x00, 0x00, 0xFF, 0x80, 0x58, 0x00, 0x00, 0x04, 0x01, 0x00, 0x0F, 0x80,
            0x01, 0x00, 0xFF, 0x81, 0x02, 0x00, 0x00, 0xA0, 0x02, 0x00, 0x55, 0xA0, 0x41, 0x00, 0x00, 0x01, 0x01, 0x00, 0x0F, 0x80, 0x02, 0x00, 0x00, 0x03,
            0x00, 0x00, 0x07, 0x80, 0x00, 0x00, 0xE4, 0x80, 0x01, 0x00, 0xE4, 0xA0, 0x05, 0x00, 0x00, 0x03, 0x00, 0x00, 0x0F, 0x80, 0x00, 0x00, 0xE4, 0x80,
            0x00, 0x00, 0x00, 0xA0, 0x01, 0x00, 0x00, 0x02, 0x00, 0x08, 0x0F, 0x80, 0x00, 0x00, 0xE4, 0x80, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xEC, 0x01, 0x00, 0x00, 0x00, 0x02, 0xFE, 0xFF,
            0xFE, 0xFF, 0x3F, 0x00, 0x43, 0x54, 0x41, 0x42, 0x1C, 0x00, 0x00, 0x00, 0xC6, 0x00, 0x00, 0x00, 0x00, 0x02, 0xFE, 0xFF, 0x03, 0x00, 0x00, 0x00,
            0x1C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0xBF, 0x00, 0x00, 0x00, 0x58, 0x00, 0x00, 0x00, 0x02, 0x00, 0x08, 0x00, 0x04, 0x00, 0x00, 0x00,
            0x64, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00, 0xB4, 0x00, 0x00, 0x00, 0x02, 0x00, 0x04, 0x00, 0x04, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00,
            0x74, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00,
            0x50, 0x72, 0x6F, 0x6A, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x00, 0xAB, 0x03, 0x00, 0x03, 0x00, 0x04, 0x00, 0x04, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x56, 0x69, 0x65, 0x77,
            0x00, 0x57, 0x6F, 0x72, 0x6C, 0x64, 0x00, 0x76, 0x73, 0x5F, 0x32, 0x5F, 0x30, 0x00, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20,
            0x28, 0x52, 0x29, 0x20, 0x48, 0x4C, 0x53, 0x4C, 0x20, 0x53, 0x68, 0x61, 0x64, 0x65, 0x72, 0x20, 0x43, 0x6F, 0x6D, 0x70, 0x69, 0x6C, 0x65, 0x72,
            0x20, 0x39, 0x2E, 0x32, 0x36, 0x2E, 0x39, 0x35, 0x32, 0x2E, 0x32, 0x38, 0x34, 0x34, 0x00, 0xAB, 0x1F, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x80,
            0x00, 0x00, 0x0F, 0x90, 0x1F, 0x00, 0x00, 0x02, 0x05, 0x00, 0x00, 0x80, 0x01, 0x00, 0x0F, 0x90, 0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x01, 0x80,
            0x00, 0x00, 0xE4, 0x90, 0x00, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x02, 0x80, 0x00, 0x00, 0xE4, 0x90, 0x01, 0x00, 0xE4, 0xA0,
            0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x04, 0x80, 0x00, 0x00, 0xE4, 0x90, 0x02, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x08, 0x80,
            0x00, 0x00, 0xE4, 0x90, 0x03, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x01, 0x00, 0x01, 0x80, 0x00, 0x00, 0xE4, 0x80, 0x04, 0x00, 0xE4, 0xA0,
            0x09, 0x00, 0x00, 0x03, 0x01, 0x00, 0x02, 0x80, 0x00, 0x00, 0xE4, 0x80, 0x05, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x01, 0x00, 0x04, 0x80,
            0x00, 0x00, 0xE4, 0x80, 0x06, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x01, 0x00, 0x08, 0x80, 0x00, 0x00, 0xE4, 0x80, 0x07, 0x00, 0xE4, 0xA0,
            0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x01, 0xC0, 0x01, 0x00, 0xE4, 0x80, 0x08, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x02, 0xC0,
            0x01, 0x00, 0xE4, 0x80, 0x09, 0x00, 0xE4, 0xA0, 0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x04, 0xC0, 0x01, 0x00, 0xE4, 0x80, 0x0A, 0x00, 0xE4, 0xA0,
            0x09, 0x00, 0x00, 0x03, 0x00, 0x00, 0x08, 0xC0, 0x01, 0x00, 0xE4, 0x80, 0x0B, 0x00, 0xE4, 0xA0, 0x01, 0x00, 0x00, 0x02, 0x00, 0x00, 0x03, 0xE0,
            0x01, 0x00, 0xE4, 0x90, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x54, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00
            #endregion
        };

		public float Alpha
		{
			set { _alpha.SetValue(value); }
			get { return _alpha.GetValueSingle(); }
		}
		public Matrix World
		{
			set { _world.SetValue(value); }
			get { return _world.GetValueMatrix(); }
		}
		public Matrix View
		{
			set { _view.SetValue(value); }
			get { return _view.GetValueMatrix(); }
		}
		public Matrix Projection
		{
			set { _projection.SetValue(value); }
			get { return _projection.GetValueMatrix(); }
		}
		public Texture2D Texture
		{
			set { _texture.SetValue(value); }
			get { return _texture.GetValueTexture2D(); }
		}
		public Vector3 Color
		{
			set { _color.SetValue(value - Vector3.One); }
			get { return _color.GetValueVector3(); }
		}

		public SpriteEffect(GraphicsDevice device)
			: base(device, _effectCode)
		{
			this.Name = "Default";
			this._alpha = Parameters["Alpha"];
			this._world = Parameters["World"];
			this._view = Parameters["View"];
			this._projection = Parameters["Projection"];
			this._texture = Parameters["Texture"];
			this._color = Parameters["Color"];
		}
		public void Apply()
		{
			base.CurrentTechnique.Passes[0].Apply();
		}
	}
}
