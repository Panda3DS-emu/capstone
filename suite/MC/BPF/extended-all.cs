# CS_ARCH_BPF, CS_MODE_LITTLE_ENDIAN+CS_MODE_BPF_EXTENDED, None
0x04,0xb4,0x97,0xa8,0xe8,0x60,0x56,0xe1 = add r4, 0xe15660e8
0x05,0xc7,0x71,0xb0,0x43,0x1f,0xb9,0xf5 = jmp +0xb071
0x07,0x76,0x01,0x28,0xc4,0x09,0xfe,0x8b = add64 r6, 0x8bfe09c4
0x0c,0x42,0x0a,0x48,0x58,0xc4,0xef,0x37 = add r2, r4
0x0f,0x09,0x40,0x54,0x67,0x24,0x2f,0x88 = add64 r9, r0
0x14,0xd9,0xba,0xb8,0x6f,0x07,0x93,0x2a = sub r9, 0x2a93076f
0x15,0x6a,0x9f,0x38,0x1a,0x9d,0xb7,0x4d = jeq r10, 0x4db79d1a, +0x389f
0x17,0xc5,0x60,0xed,0x0b,0xdc,0xe6,0x22 = sub64 r5, 0x22e6dc0b
0x18,0xa3,0x5c,0x14,0xde,0xf0,0xa5,0xff,0x9a,0x7e,0x10,0xee,0xd8,0xa4,0x2b,0x2f = lddw r3, 0x2f2ba4d8ffa5f0de
0x1c,0x73,0x68,0xa4,0x8b,0x5b,0x93,0x1f = sub r3, r7
0x1d,0x21,0x20,0x4d,0xe3,0x47,0xaf,0x1b = jeq r1, r2, +0x4d20
0x1f,0x06,0x51,0x5a,0x39,0xb2,0x10,0x10 = sub64 r6, r0
0x20,0xc7,0x0c,0x70,0xda,0x41,0x1a,0xca = ldw [0xca1a41da]
0x24,0xb6,0x69,0x66,0xe3,0xef,0xec,0x25 = mul r6, 0x25ecefe3
0x25,0x89,0xda,0x53,0x19,0x73,0x8a,0xc0 = jgt r9, 0xc08a7319, +0x53da
0x27,0xb1,0x96,0x1d,0xd4,0xab,0x2c,0x8c = mul64 r1, 0x8c2cabd4
0x28,0x4e,0xb0,0x62,0xe8,0x48,0x0b,0x0d = ldh [0xd0b48e8]
0x2c,0x78,0x03,0xf6,0x29,0x29,0x15,0xfc = mul r8, r7
0x2d,0x18,0x5b,0xfd,0x8f,0x53,0x3b,0xf0 = jgt r8, r1, +0xfd5b
0x2f,0x77,0xc7,0xa4,0x4c,0x32,0x73,0x2a = mul64 r7, r7
0x30,0x5f,0xfe,0xfc,0x85,0x66,0x7c,0x4b = ldb [0x4b7c6685]
0x34,0x46,0x49,0x33,0xe1,0x72,0xd4,0xcb = div r6, 0xcbd472e1
0x35,0xa5,0x42,0xb9,0x5b,0x37,0xa1,0x3d = jge r5, 0x3da1375b, +0xb942
0x37,0x84,0xd8,0xba,0x3b,0x84,0x55,0x1f = div64 r4, 0x1f55843b
0x38,0x8e,0x3f,0xd7,0x1c,0x3e,0x3a,0x7b = lddw [0x7b3a3e1c]
0x3d,0x1a,0xc3,0x9b,0x88,0xa2,0x3f,0x65 = jge r10, r1, +0x9bc3
0x3f,0x36,0x99,0x32,0x7e,0x07,0x59,0x7a = div64 r6, r3
0x40,0x95,0xc2,0x39,0x6b,0xe7,0xd7,0xc4 = ldw [r9+0xc4d7e76b]
0x44,0x16,0xf7,0x98,0xf7,0x02,0x92,0x94 = or r6, 0x949202f7
0x45,0x12,0xa2,0xf2,0x14,0xe7,0x2d,0x1e = jset r2, 0x1e2de714, +0xf2a2
0x47,0x36,0xf4,0xd5,0xbe,0x04,0x58,0x4d = or64 r6, 0x4d5804be
0x48,0x7e,0xfb,0x77,0xeb,0x0e,0x5a,0x0d = ldh [r7+0xd5a0eeb]
0x4c,0x81,0x0a,0x66,0xfc,0x32,0x61,0xc4 = or r1, r8
0x4d,0x10,0x67,0x44,0x4d,0x3f,0x4d,0x8b = jset r0, r1, +0x4467
0x4f,0x81,0xeb,0x6b,0xde,0x98,0x87,0x64 = or64 r1, r8
0x50,0x38,0x80,0xf8,0x04,0x70,0xd1,0x6c = ldb [r3+0x6cd17004]
0x54,0x40,0x0a,0x6a,0x4a,0xe8,0xab,0xfb = and r0, 0xfbabe84a
0x55,0xb9,0xa3,0x80,0x90,0xbc,0xc8,0x96 = jne r9, 0x96c8bc90, +0x80a3
0x57,0x30,0x12,0xe9,0x7c,0x06,0x82,0x27 = and64 r0, 0x2782067c
0x58,0x6d,0xf1,0x05,0xd3,0x50,0x4b,0xc0 = lddw [r6+0xc04b50d3]
0x5c,0x02,0x95,0xb2,0xbd,0x3f,0x38,0x37 = and r2, r0
0x5d,0x56,0xa3,0x4c,0x2a,0xc8,0x4a,0xc5 = jne r6, r5, +0x4ca3
0x5f,0x59,0xf6,0xaa,0x5d,0xeb,0x27,0xdd = and64 r9, r5
0x61,0x28,0xb2,0xed,0xb8,0xcf,0xb5,0xe4 = ldxw r8, [r2+0xedb2]
0x62,0xa5,0xdf,0xe0,0x14,0x7d,0x95,0x78 = stw [r5+0xe0df], 0x78957d14
0x63,0x77,0x2f,0xcf,0x76,0xb7,0xd3,0xfa = stxw [r7+0xcf2f], r7
0x64,0x68,0xc1,0xf4,0x88,0x92,0xd2,0xeb = lsh r8, 0xebd29288
0x65,0xe8,0x97,0xe1,0x87,0xbe,0x8f,0xf8 = jsgt r8, 0xf88fbe87, +0xe197
0x67,0x00,0xd7,0xc0,0x05,0xb0,0xf6,0x74 = lsh64 r0, 0x74f6b005
0x69,0x14,0xc7,0x8e,0x0b,0xc1,0xad,0x69 = ldxh r4, [r1+0x8ec7]
0x6a,0xb5,0xbc,0x8c,0x4f,0x5c,0x94,0x01 = sth [r5+0x8cbc], 0x1945c4f
0x6b,0x34,0x58,0xf5,0xc8,0x27,0x9e,0x14 = stxh [r4+0xf558], r3
0x6c,0x21,0x10,0x48,0x01,0x3e,0x6e,0xf8 = lsh r1, r2
0x6d,0x38,0x69,0xe3,0xc9,0xac,0x3c,0xdb = jsgt r8, r3, +0xe369
0x6f,0x64,0x49,0xd6,0x07,0xa9,0x93,0x13 = lsh64 r4, r6
0x71,0xa0,0xeb,0xfb,0x3d,0x6b,0x58,0x45 = ldxb r0, [r10+0xfbeb]
0x72,0xe2,0xc1,0x1b,0x25,0x2f,0x4a,0xdc = stb [r2+0x1bc1], 0xdc4a2f25
0x73,0x44,0x09,0x0f,0xc1,0x07,0xa8,0xf4 = stxb [r4+0xf09], r4
0x74,0xe0,0x23,0x23,0x2f,0x04,0x15,0x35 = rsh r0, 0x3515042f
0x75,0x04,0x8e,0x18,0x6a,0xcc,0x3c,0x09 = jsge r4, 0x93ccc6a, +0x188e
0x77,0x09,0x3a,0xa7,0x3c,0x6e,0xfa,0x23 = rsh64 r9, 0x23fa6e3c
0x79,0xa9,0x5c,0x7b,0x16,0x1f,0xfb,0x01 = ldxdw r9, [r10+0x7b5c]
0x7a,0xd8,0x6b,0x04,0x76,0xf0,0x51,0x75 = stdw [r8+0x46b], 0x7551f076
0x7b,0x72,0x0f,0x30,0x51,0x78,0xd2,0x9a = stxdw [r2+0x300f], r7
0x7c,0x13,0x12,0x73,0x5a,0x20,0x65,0xdb = rsh r3, r1
0x7d,0x58,0x52,0x01,0x90,0xf9,0x30,0x9a = jsge r8, r5, +0x152
0x7f,0x98,0xea,0xff,0xcf,0x5d,0x5f,0xa3 = rsh64 r8, r9
0x84,0x14,0xd4,0xaf,0x60,0xe1,0x41,0x18 = neg r4
0x85,0xd3,0xa5,0xe2,0x83,0x3d,0xbd,0x5d = call 0x5dbd3d83
0x87,0xf5,0x2b,0xbe,0xa9,0xc7,0x31,0xa3 = neg64 r5
0x94,0x39,0x0d,0xdc,0x0b,0xd2,0xd1,0xc9 = mod r9, 0xc9d1d20b
0x95,0xf2,0xd1,0x83,0x53,0xa9,0x09,0x9f = exit
0x97,0xc8,0xa6,0x75,0xd2,0x09,0x98,0x09 = mod64 r8, 0x99809d2
0x9c,0x96,0xe7,0x16,0x0f,0x69,0x13,0x90 = mod r6, r9
0x9f,0x35,0x5a,0x59,0xd6,0x70,0xd9,0x5e = mod64 r5, r3
0xa4,0x89,0x6b,0x5f,0x0d,0xbf,0x90,0xf7 = xor r9, 0xf790bf0d
0xa5,0xd4,0xef,0x79,0xd3,0xbb,0xde,0xfd = jlt r4, 0xfddebbd3, +0x79ef
0xa7,0x80,0x8b,0x18,0xa9,0x34,0x74,0x45 = xor64 r0, 0x457434a9
0xac,0x36,0x16,0xe0,0x0f,0x52,0x30,0x65 = xor r6, r3
0xaf,0x41,0x04,0xc2,0x2e,0xc9,0xf7,0x84 = xor64 r1, r4
0xb4,0xa1,0x9c,0x78,0xf9,0x3f,0x77,0x1f = mov r1, 0x1f773ff9
0xb5,0x92,0x5d,0x5a,0x49,0x33,0xfc,0x33 = jle r2, 0x33fc3349, +0x5a5d
0xb7,0x70,0x59,0x4d,0x5b,0x52,0x2a,0x99 = mov64 r0, 0x992a525b
0xbc,0x72,0x3e,0x6c,0xc9,0x8a,0x56,0xd6 = mov r2, r7
0xbd,0x19,0x80,0xe8,0x29,0x85,0xcf,0x51 = jle r9, r1, +0xe880
0xbf,0x86,0x55,0x58,0xb2,0x6d,0x14,0x03 = mov64 r6, r8
0xc4,0xb6,0xe2,0xe0,0x7c,0x68,0xc5,0x2b = arsh r6, 0x2bc5687c
0xc5,0xf2,0xeb,0xe4,0xba,0xc0,0xce,0x4f = jslt r2, 0x4fcec0ba, +0xe4eb
0xc7,0xe8,0xba,0xff,0x1f,0xef,0xc0,0x88 = arsh64 r8, 0x88c0ef1f
0xcc,0x38,0xc5,0x37,0x13,0xc0,0xe7,0x27 = arsh r8, r3
0xcd,0x90,0x67,0x88,0x6b,0xd0,0x27,0xf4 = jslt r0, r9, +0x8867
0xcf,0x82,0xe1,0xcd,0xbe,0xc3,0x2d,0x7c = arsh64 r2, r8
0xd4,0x53,0x3f,0x0c,0x40,0x00,0x00,0x00 = le64 r3
0xd5,0xe9,0xf6,0xb2,0x50,0xfd,0xb0,0xe5 = jsle r9, 0xe5b0fd50, +0xb2f6
0xdc,0xb2,0xa3,0x50,0x20,0x00,0x00,0x00 = be32 r2
0xdd,0x95,0xbf,0xb1,0xf2,0x5f,0x7b,0xc4 = jsle r5, r9, +0xb1bf
