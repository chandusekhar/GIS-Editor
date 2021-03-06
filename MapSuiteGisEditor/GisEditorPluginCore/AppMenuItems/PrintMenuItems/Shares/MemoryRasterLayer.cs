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


using System.Collections.ObjectModel;
using System.IO;
using ThinkGeo.MapSuite.Drawing;
using ThinkGeo.MapSuite.Layers;
using ThinkGeo.MapSuite.Styles;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    public class MemoryRasterLayer : RasterLayer
    {
        private GeoImage image;

        public MemoryRasterLayer(Stream imageStream)
        {
            this.ImageSource = new MemoryRasterSource();
            this.image = new GeoImage(imageStream);
        }

        protected override void DrawCore(GeoCanvas canvas, Collection<SimpleCandidate> labelsInAllLayers)
        {
            var canvasPoint = canvas.CurrentWorldExtent.GetCenterPoint();
            var worldPoint = GisEditor.ActiveMap.CurrentExtent.GetCenterPoint();

            var xOffset = worldPoint.X - canvasPoint.X;
            var yOffset = worldPoint.Y - canvasPoint.Y;

            canvas.DrawWorldImageWithoutScaling(image, canvasPoint.X + xOffset, canvasPoint.Y + yOffset, DrawingLevel.LevelOne);
        }
    }
}
