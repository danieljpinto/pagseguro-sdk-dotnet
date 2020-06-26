﻿// Copyright [2011] [PagSeguro Internet Ltda.]
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System.Collections.Generic;

namespace Uol.PagSeguro.Domain
{
    /// <inheritdoc />
    public class AcceptPaymentMethod : IAcceptedPayments
    {
        /// <inheritdoc />
        public List<string> Name { get; set; }

        /// <inheritdoc />
        public string Group { get; set; }

        /// <inheritdoc />
        public AcceptPaymentMethod(string group, List<string> name)
        {
            Name = name;
            Group = group;
        }
    }
}
