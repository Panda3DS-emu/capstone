# CS_ARCH_HPPA, CS_MODE_HPPA_11+CS_MODE_BIG_ENDIAN, None
0xd0,0x41,0x00,0x03 = vshd r1,rp,r3
0xd0,0x41,0x20,0x03 = vshd,= r1,rp,r3
0xd0,0x41,0x40,0x03 = vshd,< r1,rp,r3
0xd0,0x41,0x60,0x03 = vshd,od r1,rp,r3
0xd0,0x41,0x80,0x03 = vshd,tr r1,rp,r3
0xd0,0x41,0xa0,0x03 = vshd,<> r1,rp,r3
0xd0,0x41,0xc0,0x03 = vshd,>= r1,rp,r3
0xd0,0x41,0xe0,0x03 = vshd,ev r1,rp,r3
0xd0,0x41,0x0a,0x03 = shd r1,rp,0xf,r3
0xd0,0x41,0x2a,0x03 = shd,= r1,rp,0xf,r3
0xd0,0x41,0x4a,0x03 = shd,< r1,rp,0xf,r3
0xd0,0x41,0x6a,0x03 = shd,od r1,rp,0xf,r3
0xd0,0x41,0x8a,0x03 = shd,tr r1,rp,0xf,r3
0xd0,0x41,0xaa,0x03 = shd,<> r1,rp,0xf,r3
0xd0,0x41,0xca,0x03 = shd,>= r1,rp,0xf,r3
0xd0,0x41,0xea,0x03 = shd,ev r1,rp,0xf,r3
0xd0,0x23,0x10,0x11 = vextru r1,0xf,r3
0xd0,0x23,0x30,0x11 = vextru,= r1,0xf,r3
0xd0,0x23,0x50,0x11 = vextru,< r1,0xf,r3
0xd0,0x23,0x70,0x11 = vextru,od r1,0xf,r3
0xd0,0x23,0x90,0x11 = vextru,tr r1,0xf,r3
0xd0,0x23,0xb0,0x11 = vextru,<> r1,0xf,r3
0xd0,0x23,0xd0,0x11 = vextru,>= r1,0xf,r3
0xd0,0x23,0xf0,0x11 = vextru,ev r1,0xf,r3
0xd0,0x23,0x14,0x11 = vextrs r1,0xf,r3
0xd0,0x23,0x34,0x11 = vextrs,= r1,0xf,r3
0xd0,0x23,0x54,0x11 = vextrs,< r1,0xf,r3
0xd0,0x23,0x74,0x11 = vextrs,od r1,0xf,r3
0xd0,0x23,0x94,0x11 = vextrs,tr r1,0xf,r3
0xd0,0x23,0xb4,0x11 = vextrs,<> r1,0xf,r3
0xd0,0x23,0xd4,0x11 = vextrs,>= r1,0xf,r3
0xd0,0x23,0xf4,0x11 = vextrs,ev r1,0xf,r3
0xd0,0x23,0x19,0xd1 = extru r1,0xe,0xf,r3
0xd0,0x23,0x39,0xd1 = extru,= r1,0xe,0xf,r3
0xd0,0x23,0x59,0xd1 = extru,< r1,0xe,0xf,r3
0xd0,0x23,0x79,0xd1 = extru,od r1,0xe,0xf,r3
0xd0,0x23,0x99,0xd1 = extru,tr r1,0xe,0xf,r3
0xd0,0x23,0xb9,0xd1 = extru,<> r1,0xe,0xf,r3
0xd0,0x23,0xd9,0xd1 = extru,>= r1,0xe,0xf,r3
0xd0,0x23,0xf9,0xd1 = extru,ev r1,0xe,0xf,r3
0xd0,0x23,0x1d,0xd1 = extrs r1,0xe,0xf,r3
0xd0,0x23,0x3d,0xd1 = extrs,= r1,0xe,0xf,r3
0xd0,0x23,0x5d,0xd1 = extrs,< r1,0xe,0xf,r3
0xd0,0x23,0x7d,0xd1 = extrs,od r1,0xe,0xf,r3
0xd0,0x23,0x9d,0xd1 = extrs,tr r1,0xe,0xf,r3
0xd0,0x23,0xbd,0xd1 = extrs,<> r1,0xe,0xf,r3
0xd0,0x23,0xdd,0xd1 = extrs,>= r1,0xe,0xf,r3
0xd0,0x23,0xfd,0xd1 = extrs,ev r1,0xe,0xf,r3
0xd4,0x61,0x00,0x11 = zvdep r1,0xf,r3
0xd4,0x61,0x20,0x11 = zvdep,= r1,0xf,r3
0xd4,0x61,0x40,0x11 = zvdep,< r1,0xf,r3
0xd4,0x61,0x60,0x11 = zvdep,od r1,0xf,r3
0xd4,0x61,0x80,0x11 = zvdep,tr r1,0xf,r3
0xd4,0x61,0xa0,0x11 = zvdep,<> r1,0xf,r3
0xd4,0x61,0xc0,0x11 = zvdep,>= r1,0xf,r3
0xd4,0x61,0xe0,0x11 = zvdep,ev r1,0xf,r3
0xd4,0x61,0x04,0x11 = vdep r1,0xf,r3
0xd4,0x61,0x24,0x11 = vdep,= r1,0xf,r3
0xd4,0x61,0x44,0x11 = vdep,< r1,0xf,r3
0xd4,0x61,0x64,0x11 = vdep,od r1,0xf,r3
0xd4,0x61,0x84,0x11 = vdep,tr r1,0xf,r3
0xd4,0x61,0xa4,0x11 = vdep,<> r1,0xf,r3
0xd4,0x61,0xc4,0x11 = vdep,>= r1,0xf,r3
0xd4,0x61,0xe4,0x11 = vdep,ev r1,0xf,r3
0xd4,0x61,0x0a,0x31 = zdep r1,0xe,0xf,r3
0xd4,0x61,0x2a,0x31 = zdep,= r1,0xe,0xf,r3
0xd4,0x61,0x4a,0x31 = zdep,< r1,0xe,0xf,r3
0xd4,0x61,0x6a,0x31 = zdep,od r1,0xe,0xf,r3
0xd4,0x61,0x8a,0x31 = zdep,tr r1,0xe,0xf,r3
0xd4,0x61,0xaa,0x31 = zdep,<> r1,0xe,0xf,r3
0xd4,0x61,0xca,0x31 = zdep,>= r1,0xe,0xf,r3
0xd4,0x61,0xea,0x31 = zdep,ev r1,0xe,0xf,r3
0xd4,0x61,0x0e,0x31 = dep r1,0xe,0xf,r3
0xd4,0x61,0x2e,0x31 = dep,= r1,0xe,0xf,r3
0xd4,0x61,0x4e,0x31 = dep,< r1,0xe,0xf,r3
0xd4,0x61,0x6e,0x31 = dep,od r1,0xe,0xf,r3
0xd4,0x61,0x8e,0x31 = dep,tr r1,0xe,0xf,r3
0xd4,0x61,0xae,0x31 = dep,<> r1,0xe,0xf,r3
0xd4,0x61,0xce,0x31 = dep,>= r1,0xe,0xf,r3
0xd4,0x61,0xee,0x31 = dep,ev r1,0xe,0xf,r3
0xd4,0x7c,0x10,0x11 = zvdepi 0xe,0xf,r3
0xd4,0x7c,0x30,0x11 = zvdepi,= 0xe,0xf,r3
0xd4,0x7c,0x50,0x11 = zvdepi,< 0xe,0xf,r3
0xd4,0x7c,0x70,0x11 = zvdepi,od 0xe,0xf,r3
0xd4,0x7c,0x90,0x11 = zvdepi,tr 0xe,0xf,r3
0xd4,0x7c,0xb0,0x11 = zvdepi,<> 0xe,0xf,r3
0xd4,0x7c,0xd0,0x11 = zvdepi,>= 0xe,0xf,r3
0xd4,0x7c,0xf0,0x11 = zvdepi,ev 0xe,0xf,r3
0xd4,0x7c,0x14,0x11 = vdepi 0xe,0xf,r3
0xd4,0x7c,0x34,0x11 = vdepi,= 0xe,0xf,r3
0xd4,0x7c,0x54,0x11 = vdepi,< 0xe,0xf,r3
0xd4,0x7c,0x74,0x11 = vdepi,od 0xe,0xf,r3
0xd4,0x7c,0x94,0x11 = vdepi,tr 0xe,0xf,r3
0xd4,0x7c,0xb4,0x11 = vdepi,<> 0xe,0xf,r3
0xd4,0x7c,0xd4,0x11 = vdepi,>= 0xe,0xf,r3
0xd4,0x7c,0xf4,0x11 = vdepi,ev 0xe,0xf,r3
0xd4,0x66,0x1b,0xbf = zdepi 3,2,1,r3
0xd4,0x66,0x3b,0xbf = zdepi,= 3,2,1,r3
0xd4,0x66,0x5b,0xbf = zdepi,< 3,2,1,r3
0xd4,0x66,0x7b,0xbf = zdepi,od 3,2,1,r3
0xd4,0x66,0x9b,0xbf = zdepi,tr 3,2,1,r3
0xd4,0x66,0xbb,0xbf = zdepi,<> 3,2,1,r3
0xd4,0x66,0xdb,0xbf = zdepi,>= 3,2,1,r3
0xd4,0x66,0xfb,0xbf = zdepi,ev 3,2,1,r3
0xd4,0x66,0x1f,0xbf = depi 3,2,1,r3
0xd4,0x66,0x3f,0xbf = depi,= 3,2,1,r3
0xd4,0x66,0x5f,0xbf = depi,< 3,2,1,r3
0xd4,0x66,0x7f,0xbf = depi,od 3,2,1,r3
0xd4,0x66,0x9f,0xbf = depi,tr 3,2,1,r3
0xd4,0x66,0xbf,0xbf = depi,<> 3,2,1,r3
0xd4,0x66,0xdf,0xbf = depi,>= 3,2,1,r3
0xd4,0x66,0xff,0xbf = depi,ev 3,2,1,r3















































































































