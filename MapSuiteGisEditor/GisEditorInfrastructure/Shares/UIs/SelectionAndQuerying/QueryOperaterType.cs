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


using System.Reflection;

namespace ThinkGeo.MapSuite.GisEditor
{
    [Obfuscation]
    internal enum QueryOperaterType
    {
        Equal = 0,
        Contains = 1,
        StartsWith = 2,
        EndsWith = 3,
        DoesNotEqual = 4,
        DoesNotContain = 5,
        GreaterThan = 6,
        GreaterThanOrEqualTo = 7,
        LessThan = 8,
        LessThanOrEqualTo = 9,
        Custom = 10,
        DynamicLanguage = 11,
        DateRange = 12,
        NumbericRange = 13,
        IsEmpty = 14,
        IsNotEmpty = 15,
        ValidFeature = 16
    }
}