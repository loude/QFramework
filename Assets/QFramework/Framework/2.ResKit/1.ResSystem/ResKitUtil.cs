﻿/****************************************************************************
 * Copyright (c) 2018.7 liangxie
 * 
 * http://liangxiegame.com
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

namespace QFramework
{
    using System.IO;

    public static class ResKitUtil
    {
        #region AssetBundle 相关

        public static string AssetBundleUrl2Name(string url)
        {
            string retName = null;
            string parren = FilePath.StreamingAssetsPath + "AssetBundles/" + PlatformUtil.GetPlatformName() + "/";
            retName = url.Replace(parren, "");

            parren = FilePath.PersistentDataPath + "AssetBundles/" + PlatformUtil.GetPlatformName() + "/";
            retName = retName.Replace(parren, "");
            return retName;
        }

        public static string AssetBundleName2Url(string name)
        {
            string retUrl = FilePath.PersistentDataPath + "AssetBundles/" + PlatformUtil.GetPlatformName() + "/" + name;

            if (File.Exists(retUrl))
            {
                return retUrl;
            }

            return FilePath.StreamingAssetsPath + "AssetBundles/" + PlatformUtil.GetPlatformName() + "/" + name;
        }

        //导出目录
        public static string EDITOR_AB_EXPORT_ROOT_FOLDER
        {
            get { return "StreamingAssets/AssetBundles/" + RELATIVE_AB_ROOT_FOLDER; }
        }

        /// <summary>
        /// AssetBundle存放路径
        /// </summary>
        public static string RELATIVE_AB_ROOT_FOLDER
        {
            get { return "/AssetBundles/" + PlatformUtil.GetPlatformName() + "/"; }
        }

        /// <summary>
        /// AssetBundle 配置路径
        /// </summary>
        public static string EXPORT_ASSETBUNDLE_CONFIG_FILENAME
        {
            get { return "asset_bindle_config.bin"; }
        }

        #endregion
    }
}