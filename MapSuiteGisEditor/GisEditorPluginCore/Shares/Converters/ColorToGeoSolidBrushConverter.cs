/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using System.Windows.Data;
using System.Windows.Media;
using ThinkGeo.MapSuite.Drawing;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    public class ColorToGeoSolidBrushConverter : ValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Color)
            {
                Color mediaColor = (Color)value;
                return new GeoSolidBrush(GeoColor.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B));
            }
            else if (value is GeoSolidBrush)
            {
                GeoSolidBrush brush = (GeoSolidBrush)value;
                return Color.FromArgb(brush.Color.AlphaComponent, brush.Color.RedComponent, brush.Color.GreenComponent, brush.Color.BlueComponent);
            }
            else return Binding.DoNothing;
        }
    }
}