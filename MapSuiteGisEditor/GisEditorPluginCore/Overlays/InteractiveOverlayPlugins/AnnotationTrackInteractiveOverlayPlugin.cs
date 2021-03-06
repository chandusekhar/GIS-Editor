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
using ThinkGeo.MapSuite.Wpf;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    internal class AnnotationTrackInteractiveOverlayPlugin : TrackInteractiveOverlayPlugin
    {
        public AnnotationTrackInteractiveOverlayPlugin()
        { }

        protected override Type GetInteractiveOverlayTypeCore()
        {
            return typeof(AnnotationTrackInteractiveOverlay);
        }

        protected override void DisableCore(InteractiveOverlay interactiveOverlay)
        {
            base.DisableCore(interactiveOverlay);
            var overlay = interactiveOverlay as AnnotationTrackInteractiveOverlay;
            if (overlay != null)
            {
                overlay.TrackMode = TrackMode.None;
                overlay.IsInModifyMode = false;
            }
        }

        protected override bool GetIsEnabledCore(InteractiveOverlay interactiveOverlay)
        {
            bool isEnabled = true;
            var overlay = interactiveOverlay as AnnotationTrackInteractiveOverlay;
            if (overlay != null)
            {
                isEnabled = overlay.TrackMode != TrackMode.None || overlay.IsInModifyMode;
            }

            return isEnabled;
        }
    }
}