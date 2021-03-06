﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerrainDisplay;
using TerrainDisplay.MPQ.WDT;
using TerrainExtractor.Parsers;
using WCell.MPQTool.StormLibWrapper;
using WCell.Util.NLog;

namespace TerrainExtractor
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            LogUtil.SetupConsoleLogging();
            TerrainDisplayConfig.Initialize();
            NativeMethods.StormLibFolder = TerrainDisplayConfig.LibDir;
            NativeMethods.InitAPI();

            WDTExtractor.ExportAll();
        }

        static Program()
        {
            new TerrainDisplayConfig();
            new TileIdentifier();
        }
    }
}
