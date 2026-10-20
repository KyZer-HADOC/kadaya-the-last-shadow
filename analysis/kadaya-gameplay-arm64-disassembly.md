# Kadaya gameplay native method inspection

Read-only ARM64 disassembly from the original IL2CPP native library.
No game binary, scene, map or level file is modified by this workflow.
- Binary bytes: 52,321,112

Addresses below are from the matching Il2CppDumper method map (metadata version 31). The disassembly is for analysis only; no machine-code patches have been applied.

## NinjaMovementScript.Button_Dash_press
- RVA: 0x15c7214; window: 256 bytes; objdump exit: 0; instruction rows: 64
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015c7214 <__start_il2cpp@@Base+0x1392f8>:
 15c7214:	fc1e0fe8 	str	d8, [sp, #-32]!
 15c7218:	a9014ffe 	stp	x30, x19, [sp, #16]
 15c721c:	aa0003f3 	mov	x19, x0
 15c7220:	bd42e408 	ldr	s8, [x0, #740]
 15c7224:	aa1f03e0 	mov	x0, xzr
 15c7228:	9457995f 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15c722c:	1e202100 	fcmp	s8, s0
 15c7230:	540002e8 	b.hi	15c728c <__start_il2cpp@@Base+0x139370>  // b.pmore
 15c7234:	39494a68 	ldrb	w8, [x19, #594]
 15c7238:	350002a8 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c723c:	39494668 	ldrb	w8, [x19, #593]
 15c7240:	35000268 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c7244:	39494e68 	ldrb	w8, [x19, #595]
 15c7248:	35000228 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c724c:	394d1268 	ldrb	w8, [x19, #836]
 15c7250:	350001e8 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c7254:	394d1a68 	ldrb	w8, [x19, #838]
 15c7258:	350001a8 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c725c:	394d1668 	ldrb	w8, [x19, #837]
 15c7260:	35000168 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c7264:	3946d668 	ldrb	w8, [x19, #437]
 15c7268:	35000128 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c726c:	3946d268 	ldrb	w8, [x19, #436]
 15c7270:	350000e8 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c7274:	3946da68 	ldrb	w8, [x19, #438]
 15c7278:	350000a8 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c727c:	394e9a68 	ldrb	w8, [x19, #934]
 15c7280:	35000068 	cbnz	w8, 15c728c <__start_il2cpp@@Base+0x139370>
 15c7284:	3953e268 	ldrb	w8, [x19, #1272]
 15c7288:	34000088 	cbz	w8, 15c7298 <__start_il2cpp@@Base+0x13937c>
 15c728c:	a9414ffe 	ldp	x30, x19, [sp, #16]
 15c7290:	fc4207e8 	ldr	d8, [sp], #32
 15c7294:	d65f03c0 	ret
 15c7298:	aa1f03e0 	mov	x0, xzr
 15c729c:	94579942 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15c72a0:	bd413661 	ldr	s1, [x19, #308]
 15c72a4:	f940e260 	ldr	x0, [x19, #448]
 15c72a8:	1e212800 	fadd	s0, s0, s1
 15c72ac:	bd02e660 	str	s0, [x19, #740]
 15c72b0:	b4000180 	cbz	x0, 15c72e0 <__start_il2cpp@@Base+0x1393c4>
 15c72b4:	1e204020 	fmov	s0, s1
 15c72b8:	aa1f03e1 	mov	x1, xzr
 15c72bc:	97ffc92b 	bl	15b9768 <__start_il2cpp@@Base+0x12b84c>
 15c72c0:	aa1303e0 	mov	x0, x19
 15c72c4:	94001d53 	bl	15ce810 <__start_il2cpp@@Base+0x1408f4>
 15c72c8:	aa0003e1 	mov	x1, x0
 15c72cc:	aa1303e0 	mov	x0, x19
 15c72d0:	aa1f03e2 	mov	x2, xzr
 15c72d4:	a9414ffe 	ldp	x30, x19, [sp, #16]
 15c72d8:	fc4207e8 	ldr	d8, [sp], #32
 15c72dc:	14577fb7 	b	2ba71b8 <__start_il2cpp@@Base+0x171929c>
 15c72e0:	97f759ad 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15c72e4:	a9bf4ffe 	stp	x30, x19, [sp, #-16]!
 15c72e8:	394c0008 	ldrb	w8, [x0, #768]
 15c72ec:	aa0003f3 	mov	x19, x0
 15c72f0:	34000088 	cbz	w8, 15c7300 <__start_il2cpp@@Base+0x1393e4>
 15c72f4:	aa1303e0 	mov	x0, x19
 15c72f8:	a8c14ffe 	ldp	x30, x19, [sp], #16
 15c72fc:	140007ca 	b	15c9224 <__start_il2cpp@@Base+0x13b308>
 15c7300:	39494668 	ldrb	w8, [x19, #593]
 15c7304:	35000208 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7308:	39494a68 	ldrb	w8, [x19, #594]
 15c730c:	350001c8 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7310:	394d1268 	ldrb	w8, [x19, #836]
ASM END

## NinjaMovementScript.Dash iterator entry
- RVA: 0x15ce810; window: 256 bytes; objdump exit: 0; instruction rows: 64
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce810 <__start_il2cpp@@Base+0x1408f4>:
 15ce810:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15ce814:	a9014ff4 	stp	x20, x19, [sp, #16]
 15ce818:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce81c:	9000d1b5 	adrp	x21, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ce820:	aa0003f3 	mov	x19, x0
 15ce824:	3969ce88 	ldrb	w8, [x20, #2675]
 15ce828:	f9400eb5 	ldr	x21, [x21, #24]
 15ce82c:	370000c8 	tbnz	w8, #0, 15ce844 <__start_il2cpp@@Base+0x140928>
 15ce830:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ce834:	f9400c00 	ldr	x0, [x0, #24]
 15ce838:	97f73bc5 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce83c:	52800028 	mov	w8, #0x1                   	// #1
 15ce840:	3929ce88 	strb	w8, [x20, #2675]
 15ce844:	f94002a0 	ldr	x0, [x21]
 15ce848:	97f73c4f 	bl	139d984 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb86c>
 15ce84c:	2a1f03e1 	mov	w1, wzr
 15ce850:	aa1f03e2 	mov	x2, xzr
 15ce854:	aa0003f4 	mov	x20, x0
 15ce858:	94000adc 	bl	15d13c8 <__start_il2cpp@@Base+0x1434ac>
 15ce85c:	b40000d4 	cbz	x20, 15ce874 <__start_il2cpp@@Base+0x140958>
 15ce860:	aa1403e0 	mov	x0, x20
 15ce864:	f9001293 	str	x19, [x20, #32]
 15ce868:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15ce86c:	a8c257fe 	ldp	x30, x21, [sp], #32
 15ce870:	d65f03c0 	ret
 15ce874:	97f73c48 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce878:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15ce87c:	a9014ff4 	stp	x20, x19, [sp, #16]
 15ce880:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce884:	aa0003f3 	mov	x19, x0
 15ce888:	3969d288 	ldrb	w8, [x20, #2676]
 15ce88c:	37000128 	tbnz	w8, #0, 15ce8b0 <__start_il2cpp@@Base+0x140994>
 15ce890:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce894:	f944c400 	ldr	x0, [x0, #2440]
 15ce898:	97f73bad 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce89c:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ce8a0:	f9401000 	ldr	x0, [x0, #32]
 15ce8a4:	97f73baa 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce8a8:	52800028 	mov	w8, #0x1                   	// #1
 15ce8ac:	3929d288 	strb	w8, [x20, #2676]
 15ce8b0:	394e9268 	ldrb	w8, [x19, #932]
 15ce8b4:	34000088 	cbz	w8, 15ce8c4 <__start_il2cpp@@Base+0x1409a8>
 15ce8b8:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15ce8bc:	a8c257fe 	ldp	x30, x21, [sp], #32
 15ce8c0:	d65f03c0 	ret
 15ce8c4:	b000d195 	adrp	x21, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce8c8:	52800028 	mov	w8, #0x1                   	// #1
 15ce8cc:	aa1303e0 	mov	x0, x19
 15ce8d0:	f944c6b5 	ldr	x21, [x21, #2440]
 15ce8d4:	390e9268 	strb	w8, [x19, #932]
 15ce8d8:	f94002a1 	ldr	x1, [x21]
 15ce8dc:	940769f1 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15ce8e0:	f94002a1 	ldr	x1, [x21]
 15ce8e4:	aa0003f4 	mov	x20, x0
 15ce8e8:	aa1303e0 	mov	x0, x19
 15ce8ec:	940769ed 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15ce8f0:	b40005e0 	cbz	x0, 15ce9ac <__start_il2cpp@@Base+0x140a90>
 15ce8f4:	aa1f03e1 	mov	x1, xzr
 15ce8f8:	9458b2bd 	bl	2bfb3ec <__start_il2cpp@@Base+0x176d4d0>
 15ce8fc:	b4000594 	cbz	x20, 15ce9ac <__start_il2cpp@@Base+0x140a90>
 15ce900:	2f00e400 	movi	d0, #0x0
 15ce904:	aa1403e0 	mov	x0, x20
 15ce908:	aa1f03e1 	mov	x1, xzr
 15ce90c:	9458b2eb 	bl	2bfb4b8 <__start_il2cpp@@Base+0x176d59c>
ASM END

## NinjaMovementScript.Button_Trans_press
- RVA: 0x15c72e4; window: 256 bytes; objdump exit: 0; instruction rows: 64
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015c72e4 <__start_il2cpp@@Base+0x1393c8>:
 15c72e4:	a9bf4ffe 	stp	x30, x19, [sp, #-16]!
 15c72e8:	394c0008 	ldrb	w8, [x0, #768]
 15c72ec:	aa0003f3 	mov	x19, x0
 15c72f0:	34000088 	cbz	w8, 15c7300 <__start_il2cpp@@Base+0x1393e4>
 15c72f4:	aa1303e0 	mov	x0, x19
 15c72f8:	a8c14ffe 	ldp	x30, x19, [sp], #16
 15c72fc:	140007ca 	b	15c9224 <__start_il2cpp@@Base+0x13b308>
 15c7300:	39494668 	ldrb	w8, [x19, #593]
 15c7304:	35000208 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7308:	39494a68 	ldrb	w8, [x19, #594]
 15c730c:	350001c8 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7310:	394d1268 	ldrb	w8, [x19, #836]
 15c7314:	35000188 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7318:	394d1a68 	ldrb	w8, [x19, #838]
 15c731c:	35000148 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7320:	394e9a68 	ldrb	w8, [x19, #934]
 15c7324:	35000108 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7328:	3953e268 	ldrb	w8, [x19, #1272]
 15c732c:	350000c8 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7330:	3946da68 	ldrb	w8, [x19, #438]
 15c7334:	35000088 	cbnz	w8, 15c7344 <__start_il2cpp@@Base+0x139428>
 15c7338:	aa1303e0 	mov	x0, x19
 15c733c:	94001ca3 	bl	15ce5c8 <__start_il2cpp@@Base+0x1406ac>
 15c7340:	b901ba7f 	str	wzr, [x19, #440]
 15c7344:	a8c14ffe 	ldp	x30, x19, [sp], #16
 15c7348:	d65f03c0 	ret
 15c734c:	d10783ff 	sub	sp, sp, #0x1e0
 15c7350:	6d143bef 	stp	d15, d14, [sp, #320]
 15c7354:	6d1533ed 	stp	d13, d12, [sp, #336]
 15c7358:	6d162beb 	stp	d11, d10, [sp, #352]
 15c735c:	6d1723e9 	stp	d9, d8, [sp, #368]
 15c7360:	a9187bfd 	stp	x29, x30, [sp, #384]
 15c7364:	a9196ffc 	stp	x28, x27, [sp, #400]
 15c7368:	a91a67fa 	stp	x26, x25, [sp, #416]
 15c736c:	a91b5ff8 	stp	x24, x23, [sp, #432]
 15c7370:	a91c57f6 	stp	x22, x21, [sp, #448]
 15c7374:	a91d4ff4 	stp	x20, x19, [sp, #464]
 15c7378:	d000e154 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15c737c:	aa0003f3 	mov	x19, x0
 15c7380:	39697288 	ldrb	w8, [x20, #2652]
 15c7384:	37000788 	tbnz	w8, #0, 15c7474 <__start_il2cpp@@Base+0x139558>
 15c7388:	9000d1c0 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15c738c:	f944c400 	ldr	x0, [x0, #2440]
 15c7390:	97f758ef 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c7394:	d000d1c0 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15c7398:	f9472800 	ldr	x0, [x0, #3664]
 15c739c:	97f758ec 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73a0:	9000d1c0 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15c73a4:	f9460400 	ldr	x0, [x0, #3080]
 15c73a8:	97f758e9 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73ac:	f000d1a0 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15c73b0:	f944f000 	ldr	x0, [x0, #2528]
 15c73b4:	97f758e6 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73b8:	d000d1c0 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15c73bc:	f9472c00 	ldr	x0, [x0, #3672]
 15c73c0:	97f758e3 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73c4:	f000d1a0 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15c73c8:	f946c400 	ldr	x0, [x0, #3464]
 15c73cc:	97f758e0 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73d0:	d000d1c0 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15c73d4:	f9473000 	ldr	x0, [x0, #3680]
 15c73d8:	97f758dd 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15c73dc:	d000d1c0 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15c73e0:	f9473400 	ldr	x0, [x0, #3688]
ASM END

## NinjaMovementScript.bienhinhxuoi
- RVA: 0x15ce5c8; window: 384 bytes; objdump exit: 0; instruction rows: 96
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce5c8 <__start_il2cpp@@Base+0x1406ac>:
 15ce5c8:	6dbd23e9 	stp	d9, d8, [sp, #-48]!
 15ce5cc:	a90157fe 	stp	x30, x21, [sp, #16]
 15ce5d0:	a9024ff4 	stp	x20, x19, [sp, #32]
 15ce5d4:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce5d8:	aa0003f3 	mov	x19, x0
 15ce5dc:	3969c688 	ldrb	w8, [x20, #2673]
 15ce5e0:	370000c8 	tbnz	w8, #0, 15ce5f8 <__start_il2cpp@@Base+0x1406dc>
 15ce5e4:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce5e8:	f944c400 	ldr	x0, [x0, #2440]
 15ce5ec:	97f73c58 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce5f0:	52800028 	mov	w8, #0x1                   	// #1
 15ce5f4:	3929c688 	strb	w8, [x20, #2673]
 15ce5f8:	bd42ee68 	ldr	s8, [x19, #748]
 15ce5fc:	aa1f03e0 	mov	x0, xzr
 15ce600:	94577c69 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce604:	1e202100 	fcmp	s8, s0
 15ce608:	540000a9 	b.ls	15ce61c <__start_il2cpp@@Base+0x140700>  // b.plast
 15ce60c:	a9424ff4 	ldp	x20, x19, [sp, #32]
 15ce610:	a94157fe 	ldp	x30, x21, [sp, #16]
 15ce614:	6cc323e9 	ldp	d9, d8, [sp], #48
 15ce618:	d65f03c0 	ret
 15ce61c:	f9415274 	ldr	x20, [x19, #672]
 15ce620:	aa1303e0 	mov	x0, x19
 15ce624:	aa1f03e1 	mov	x1, xzr
 15ce628:	94574e90 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce62c:	b4000f00 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce630:	aa1f03e1 	mov	x1, xzr
 15ce634:	94575bee 	bl	2ba55ec <__start_il2cpp@@Base+0x17176d0>
 15ce638:	b4000ea0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce63c:	aa1f03e1 	mov	x1, xzr
 15ce640:	945788bd 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15ce644:	b4000e54 	cbz	x20, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce648:	aa1403e0 	mov	x0, x20
 15ce64c:	aa1f03e1 	mov	x1, xzr
 15ce650:	97fd6ae2 	bl	15291d8 <__start_il2cpp@@Base+0x9b2bc>
 15ce654:	bd403e60 	ldr	s0, [x19, #60]
 15ce658:	f940e268 	ldr	x8, [x19, #448]
 15ce65c:	bd002660 	str	s0, [x19, #36]
 15ce660:	b4000d68 	cbz	x8, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce664:	394fc509 	ldrb	w9, [x8, #1009]
 15ce668:	394df514 	ldrb	w20, [x8, #893]
 15ce66c:	34000149 	cbz	w9, 15ce694 <__start_il2cpp@@Base+0x140778>
 15ce670:	394fc915 	ldrb	w21, [x8, #1010]
 15ce674:	bd415269 	ldr	s9, [x19, #336]
 15ce678:	aa1f03e0 	mov	x0, xzr
 15ce67c:	94577c4a 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce680:	340001d4 	cbz	w20, 15ce6b8 <__start_il2cpp@@Base+0x14079c>
 15ce684:	34000155 	cbz	w21, 15ce6ac <__start_il2cpp@@Base+0x140790>
 15ce688:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce68c:	bd46bd08 	ldr	s8, [x8, #1724]
 15ce690:	1400000d 	b	15ce6c4 <__start_il2cpp@@Base+0x1407a8>
 15ce694:	34000314 	cbz	w20, 15ce6f4 <__start_il2cpp@@Base+0x1407d8>
 15ce698:	394fc914 	ldrb	w20, [x8, #1010]
 15ce69c:	bd415269 	ldr	s9, [x19, #336]
 15ce6a0:	aa1f03e0 	mov	x0, xzr
 15ce6a4:	94577c40 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce6a8:	340000b4 	cbz	w20, 15ce6bc <__start_il2cpp@@Base+0x1407a0>
 15ce6ac:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce6b0:	bd457d08 	ldr	s8, [x8, #1404]
 15ce6b4:	14000004 	b	15ce6c4 <__start_il2cpp@@Base+0x1407a8>
 15ce6b8:	35ffffb5 	cbnz	w21, 15ce6ac <__start_il2cpp@@Base+0x140790>
 15ce6bc:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce6c0:	bd456908 	ldr	s8, [x8, #1384]
 15ce6c4:	1e282800 	fadd	s0, s0, s8
 15ce6c8:	1e202120 	fcmp	s9, s0
 15ce6cc:	54000145 	b.pl	15ce6f4 <__start_il2cpp@@Base+0x1407d8>  // b.nfrst
 15ce6d0:	aa1f03e0 	mov	x0, xzr
 15ce6d4:	94577c34 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce6d8:	1e282800 	fadd	s0, s0, s8
 15ce6dc:	f9415260 	ldr	x0, [x19, #672]
 15ce6e0:	bd015260 	str	s0, [x19, #336]
 15ce6e4:	b4000940 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce6e8:	1e204100 	fmov	s0, s8
 15ce6ec:	aa1f03e1 	mov	x1, xzr
 15ce6f0:	97fd6ea5 	bl	152a184 <__start_il2cpp@@Base+0x9c268>
 15ce6f4:	f9408260 	ldr	x0, [x19, #256]
 15ce6f8:	b40008a0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce6fc:	aa1f03e1 	mov	x1, xzr
 15ce700:	94574e5a 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce704:	b4000840 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce708:	52800021 	mov	w1, #0x1                   	// #1
 15ce70c:	aa1f03e2 	mov	x2, xzr
 15ce710:	94575c43 	bl	2ba581c <__start_il2cpp@@Base+0x1717900>
 15ce714:	f9408660 	ldr	x0, [x19, #264]
 15ce718:	b40007a0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce71c:	aa1f03e1 	mov	x1, xzr
 15ce720:	94574e52 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce724:	b4000740 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce728:	2a1f03e1 	mov	w1, wzr
 15ce72c:	aa1f03e2 	mov	x2, xzr
 15ce730:	94575c3b 	bl	2ba581c <__start_il2cpp@@Base+0x1717900>
 15ce734:	f9406e60 	ldr	x0, [x19, #216]
 15ce738:	b40006a0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce73c:	aa1f03e1 	mov	x1, xzr
 15ce740:	94574e4a 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce744:	b4000640 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
ASM END

## NinjaMovementScript.Button_Fi_press
- RVA: 0x15ce2b8; window: 288 bytes; objdump exit: 0; instruction rows: 72
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce2b8 <__start_il2cpp@@Base+0x14039c>:
 15ce2b8:	a9bf4ffe 	stp	x30, x19, [sp, #-16]!
 15ce2bc:	3946b008 	ldrb	w8, [x0, #428]
 15ce2c0:	34000268 	cbz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2c4:	39494408 	ldrb	w8, [x0, #593]
 15ce2c8:	35000228 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2cc:	3946d008 	ldrb	w8, [x0, #436]
 15ce2d0:	350001e8 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2d4:	3946d408 	ldrb	w8, [x0, #437]
 15ce2d8:	350001a8 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2dc:	3946d808 	ldrb	w8, [x0, #438]
 15ce2e0:	35000168 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2e4:	39494808 	ldrb	w8, [x0, #594]
 15ce2e8:	35000128 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2ec:	39494c08 	ldrb	w8, [x0, #595]
 15ce2f0:	350000e8 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2f4:	394d1008 	ldrb	w8, [x0, #836]
 15ce2f8:	350000a8 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce2fc:	394d1808 	ldrb	w8, [x0, #838]
 15ce300:	35000068 	cbnz	w8, 15ce30c <__start_il2cpp@@Base+0x1403f0>
 15ce304:	3953e008 	ldrb	w8, [x0, #1272]
 15ce308:	34000068 	cbz	w8, 15ce314 <__start_il2cpp@@Base+0x1403f8>
 15ce30c:	a8c14ffe 	ldp	x30, x19, [sp], #16
 15ce310:	d65f03c0 	ret
 15ce314:	f940e008 	ldr	x8, [x0, #448]
 15ce318:	b4000268 	cbz	x8, 15ce364 <__start_il2cpp@@Base+0x140448>
 15ce31c:	bd412800 	ldr	s0, [x0, #296]
 15ce320:	aa0003f3 	mov	x19, x0
 15ce324:	aa0803e0 	mov	x0, x8
 15ce328:	aa1f03e1 	mov	x1, xzr
 15ce32c:	97ffad2b 	bl	15b97d8 <__start_il2cpp@@Base+0x12b8bc>
 15ce330:	aa1303e0 	mov	x0, x19
 15ce334:	9400000d 	bl	15ce368 <__start_il2cpp@@Base+0x14044c>
 15ce338:	aa0003e1 	mov	x1, x0
 15ce33c:	aa1303e0 	mov	x0, x19
 15ce340:	aa1f03e2 	mov	x2, xzr
 15ce344:	9457639d 	bl	2ba71b8 <__start_il2cpp@@Base+0x171929c>
 15ce348:	aa1303e0 	mov	x0, x19
 15ce34c:	94000021 	bl	15ce3d0 <__start_il2cpp@@Base+0x1404b4>
 15ce350:	aa0003e1 	mov	x1, x0
 15ce354:	aa1303e0 	mov	x0, x19
 15ce358:	aa1f03e2 	mov	x2, xzr
 15ce35c:	a8c14ffe 	ldp	x30, x19, [sp], #16
 15ce360:	14576396 	b	2ba71b8 <__start_il2cpp@@Base+0x171929c>
 15ce364:	97f73d8c 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce368:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15ce36c:	a9014ff4 	stp	x20, x19, [sp, #16]
 15ce370:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce374:	9000d1b5 	adrp	x21, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ce378:	aa0003f3 	mov	x19, x0
 15ce37c:	3969be88 	ldrb	w8, [x20, #2671]
 15ce380:	f94006b5 	ldr	x21, [x21, #8]
 15ce384:	370000c8 	tbnz	w8, #0, 15ce39c <__start_il2cpp@@Base+0x140480>
 15ce388:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ce38c:	f9400400 	ldr	x0, [x0, #8]
 15ce390:	97f73cef 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce394:	52800028 	mov	w8, #0x1                   	// #1
 15ce398:	3929be88 	strb	w8, [x20, #2671]
 15ce39c:	f94002a0 	ldr	x0, [x21]
 15ce3a0:	97f73d79 	bl	139d984 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb86c>
 15ce3a4:	2a1f03e1 	mov	w1, wzr
 15ce3a8:	aa1f03e2 	mov	x2, xzr
 15ce3ac:	aa0003f4 	mov	x20, x0
 15ce3b0:	94000d13 	bl	15d17fc <__start_il2cpp@@Base+0x1438e0>
 15ce3b4:	b40000d4 	cbz	x20, 15ce3cc <__start_il2cpp@@Base+0x1404b0>
 15ce3b8:	aa1403e0 	mov	x0, x20
 15ce3bc:	f9001293 	str	x19, [x20, #32]
 15ce3c0:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15ce3c4:	a8c257fe 	ldp	x30, x21, [sp], #32
 15ce3c8:	d65f03c0 	ret
 15ce3cc:	97f73d72 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce3d0:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15ce3d4:	a9014ff4 	stp	x20, x19, [sp, #16]
ASM END

## NinjaMovementScript.Fi iterator MoveNext
- RVA: 0x15d1828; window: 768 bytes; objdump exit: 0; instruction rows: 192
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015d1828 <__start_il2cpp@@Base+0x14390c>:
 15d1828:	d10503ff 	sub	sp, sp, #0x140
 15d182c:	6d0e2beb 	stp	d11, d10, [sp, #224]
 15d1830:	6d0f23e9 	stp	d9, d8, [sp, #240]
 15d1834:	f90083fd 	str	x29, [sp, #256]
 15d1838:	a9115ffe 	stp	x30, x23, [sp, #272]
 15d183c:	a91257f6 	stp	x22, x21, [sp, #288]
 15d1840:	a9134ff4 	stp	x20, x19, [sp, #304]
 15d1844:	9000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d1848:	aa0003f3 	mov	x19, x0
 15d184c:	396a6e88 	ldrb	w8, [x20, #2715]
 15d1850:	37000368 	tbnz	w8, #0, 15d18bc <__start_il2cpp@@Base+0x1439a0>
 15d1854:	d000d160 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15d1858:	f9460400 	ldr	x0, [x0, #3080]
 15d185c:	97f72fbc 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1860:	b000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1864:	f9468800 	ldr	x0, [x0, #3344]
 15d1868:	97f72fb9 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d186c:	f000d160 	adrp	x0, 3000000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x4738>
 15d1870:	f9468c00 	ldr	x0, [x0, #3352]
 15d1874:	97f72fb6 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1878:	b000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d187c:	f946c400 	ldr	x0, [x0, #3464]
 15d1880:	97f72fb3 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1884:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1888:	f9408400 	ldr	x0, [x0, #264]
 15d188c:	97f72fb0 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1890:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1894:	f9404c00 	ldr	x0, [x0, #152]
 15d1898:	97f72fad 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d189c:	9000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d18a0:	f9472400 	ldr	x0, [x0, #3656]
 15d18a4:	97f72faa 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d18a8:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d18ac:	f9408800 	ldr	x0, [x0, #272]
 15d18b0:	97f72fa7 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d18b4:	52800028 	mov	w8, #0x1                   	// #1
 15d18b8:	392a6e88 	strb	w8, [x20, #2715]
 15d18bc:	6f00e400 	movi	v0.2d, #0x0
 15d18c0:	b9401276 	ldr	w22, [x19, #16]
 15d18c4:	f9401277 	ldr	x23, [x19, #32]
 15d18c8:	b900d3ff 	str	wzr, [sp, #208]
 15d18cc:	b900a3ff 	str	wzr, [sp, #160]
 15d18d0:	ad0403e0 	stp	q0, q0, [sp, #128]
 15d18d4:	ad0583e0 	stp	q0, q0, [sp, #176]
 15d18d8:	340001f6 	cbz	w22, 15d1914 <__start_il2cpp@@Base+0x1439f8>
 15d18dc:	710006df 	cmp	w22, #0x1
 15d18e0:	54002ea1 	b.ne	15d1eb4 <__start_il2cpp@@Base+0x143f98>  // b.any
 15d18e4:	12800008 	mov	w8, #0xffffffff            	// #-1
 15d18e8:	b9001268 	str	w8, [x19, #16]
 15d18ec:	b4002f97 	cbz	x23, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d18f0:	f9403ee0 	ldr	x0, [x23, #120]
 15d18f4:	b4002f40 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d18f8:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d18fc:	2a1f03e2 	mov	w2, wzr
 15d1900:	aa1f03e3 	mov	x3, xzr
 15d1904:	f9408908 	ldr	x8, [x8, #272]
 15d1908:	f9400101 	ldr	x1, [x8]
 15d190c:	9456598d 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d1910:	14000169 	b	15d1eb4 <__start_il2cpp@@Base+0x143f98>
 15d1914:	12800008 	mov	w8, #0xffffffff            	// #-1
 15d1918:	b9001268 	str	w8, [x19, #16]
 15d191c:	b4002e17 	cbz	x23, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1920:	394782e8 	ldrb	w8, [x23, #480]
 15d1924:	f9403ee0 	ldr	x0, [x23, #120]
 15d1928:	3906b2ff 	strb	wzr, [x23, #428]
 15d192c:	b4002d80 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1930:	b000d189 	adrp	x9, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1934:	7100011f 	cmp	w8, #0x0
 15d1938:	aa1f03e3 	mov	x3, xzr
 15d193c:	f9408929 	ldr	x9, [x9, #272]
 15d1940:	1a9f17e2 	cset	w2, eq	// eq = none
 15d1944:	f9400121 	ldr	x1, [x9]
 15d1948:	9456597e 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d194c:	f9403ee0 	ldr	x0, [x23, #120]
 15d1950:	b4002c60 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1954:	9000d188 	adrp	x8, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d1958:	2a1f03e2 	mov	w2, wzr
 15d195c:	aa1f03e3 	mov	x3, xzr
 15d1960:	f9472508 	ldr	x8, [x8, #3656]
 15d1964:	f9400101 	ldr	x1, [x8]
 15d1968:	94565976 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d196c:	f9403ee0 	ldr	x0, [x23, #120]
 15d1970:	b4002b60 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1974:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1978:	aa1f03e2 	mov	x2, xzr
 15d197c:	f9404d08 	ldr	x8, [x8, #152]
 15d1980:	f9400101 	ldr	x1, [x8]
 15d1984:	94565a49 	bl	2b682a8 <__start_il2cpp@@Base+0x16da38c>
 15d1988:	aa1f03e0 	mov	x0, xzr
 15d198c:	391212ff 	strb	wzr, [x23, #1156]
 15d1990:	94576f85 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15d1994:	bd4476e1 	ldr	s1, [x23, #1140]
 15d1998:	1e212000 	fcmp	s0, s1
 15d199c:	54001d4d 	b.le	15d1d44 <__start_il2cpp@@Base+0x143e28>
 15d19a0:	3947fae9 	ldrb	w9, [x23, #510]
 15d19a4:	394e9ae8 	ldrb	w8, [x23, #934]
 15d19a8:	f9405ee0 	ldr	x0, [x23, #184]
 15d19ac:	340002a9 	cbz	w9, 15d1a00 <__start_il2cpp@@Base+0x143ae4>
 15d19b0:	34000508 	cbz	w8, 15d1a50 <__start_il2cpp@@Base+0x143b34>
 15d19b4:	b4002940 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d19b8:	aa1f03e1 	mov	x1, xzr
 15d19bc:	94577bde 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15d19c0:	1e204008 	fmov	s8, s0
 15d19c4:	2f00e40a 	movi	d10, #0x0
 15d19c8:	9000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d19cc:	1e204029 	fmov	s9, s1
 15d19d0:	1e3c100b 	fmov	s11, #-5.000000000000000000e-01
 15d19d4:	39591288 	ldrb	w8, [x20, #1604]
 15d19d8:	350000c8 	cbnz	w8, 15d19f0 <__start_il2cpp@@Base+0x143ad4>
 15d19dc:	b000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d19e0:	f944f000 	ldr	x0, [x0, #2528]
 15d19e4:	97f72f5a 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d19e8:	52800028 	mov	w8, #0x1                   	// #1
 15d19ec:	39191288 	strb	w8, [x20, #1604]
 15d19f0:	b000d168 	adrp	x8, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d19f4:	1e2a2908 	fadd	s8, s8, s10
 15d19f8:	1e2b2929 	fadd	s9, s9, s11
 15d19fc:	14000023 	b	15d1a88 <__start_il2cpp@@Base+0x143b6c>
 15d1a00:	34000d48 	cbz	w8, 15d1ba8 <__start_il2cpp@@Base+0x143c8c>
 15d1a04:	b40026c0 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1a08:	aa1f03e1 	mov	x1, xzr
 15d1a0c:	94577bca 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15d1a10:	1e204008 	fmov	s8, s0
 15d1a14:	2f00e40a 	movi	d10, #0x0
 15d1a18:	9000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d1a1c:	1e204029 	fmov	s9, s1
 15d1a20:	1e3c100b 	fmov	s11, #-5.000000000000000000e-01
 15d1a24:	39590a88 	ldrb	w8, [x20, #1602]
 15d1a28:	350000c8 	cbnz	w8, 15d1a40 <__start_il2cpp@@Base+0x143b24>
 15d1a2c:	b000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1a30:	f944f000 	ldr	x0, [x0, #2528]
 15d1a34:	97f72f46 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1a38:	52800028 	mov	w8, #0x1                   	// #1
 15d1a3c:	39190a88 	strb	w8, [x20, #1602]
 15d1a40:	b000d168 	adrp	x8, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1a44:	1e2a2908 	fadd	s8, s8, s10
 15d1a48:	1e2b2929 	fadd	s9, s9, s11
 15d1a4c:	14000065 	b	15d1be0 <__start_il2cpp@@Base+0x143cc4>
 15d1a50:	b4002460 	cbz	x0, 15d1edc <__start_il2cpp@@Base+0x143fc0>
 15d1a54:	aa1f03e1 	mov	x1, xzr
 15d1a58:	94577bb7 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15d1a5c:	1e204008 	fmov	s8, s0
 15d1a60:	1e204029 	fmov	s9, s1
 15d1a64:	9000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d1a68:	39591288 	ldrb	w8, [x20, #1604]
 15d1a6c:	350000c8 	cbnz	w8, 15d1a84 <__start_il2cpp@@Base+0x143b68>
 15d1a70:	b000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1a74:	f944f000 	ldr	x0, [x0, #2528]
 15d1a78:	97f72f35 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1a7c:	52800028 	mov	w8, #0x1                   	// #1
 15d1a80:	39191288 	strb	w8, [x20, #1604]
 15d1a84:	b000d168 	adrp	x8, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1a88:	f944f108 	ldr	x8, [x8, #2528]
 15d1a8c:	f9400108 	ldr	x8, [x8]
 15d1a90:	f9405d08 	ldr	x8, [x8, #184]
 15d1a94:	b9447ae0 	ldr	w0, [x23, #1144]
 15d1a98:	aa1f03e1 	mov	x1, xzr
 15d1a9c:	2d452d0a 	ldp	s10, s11, [x8, #40]
 15d1aa0:	945751f2 	bl	2ba6268 <__start_il2cpp@@Base+0x171834c>
 15d1aa4:	d000d168 	adrp	x8, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15d1aa8:	2a0003f4 	mov	w20, w0
 15d1aac:	f9460508 	ldr	x8, [x8, #3080]
 15d1ab0:	f9400108 	ldr	x8, [x8]
ASM END

## NinjaMovementScript.Button_Chem_press
- RVA: 0x15cec64; window: 288 bytes; objdump exit: 0; instruction rows: 72
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015cec64 <__start_il2cpp@@Base+0x140d48>:
 15cec64:	fc1e0fe8 	str	d8, [sp, #-32]!
 15cec68:	a9014ffe 	stp	x30, x19, [sp, #16]
 15cec6c:	aa0003f3 	mov	x19, x0
 15cec70:	bd42e808 	ldr	s8, [x0, #744]
 15cec74:	aa1f03e0 	mov	x0, xzr
 15cec78:	94577acb 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15cec7c:	1e202100 	fcmp	s8, s0
 15cec80:	54000228 	b.hi	15cecc4 <__start_il2cpp@@Base+0x140da8>  // b.pmore
 15cec84:	39494a68 	ldrb	w8, [x19, #594]
 15cec88:	350001e8 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cec8c:	39494e68 	ldrb	w8, [x19, #595]
 15cec90:	350001a8 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cec94:	394d1268 	ldrb	w8, [x19, #836]
 15cec98:	35000168 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cec9c:	394d1a68 	ldrb	w8, [x19, #838]
 15ceca0:	35000128 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15ceca4:	394d1668 	ldrb	w8, [x19, #837]
 15ceca8:	350000e8 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cecac:	3946d268 	ldrb	w8, [x19, #436]
 15cecb0:	350000a8 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cecb4:	3946d668 	ldrb	w8, [x19, #437]
 15cecb8:	35000068 	cbnz	w8, 15cecc4 <__start_il2cpp@@Base+0x140da8>
 15cecbc:	3946da68 	ldrb	w8, [x19, #438]
 15cecc0:	34000088 	cbz	w8, 15cecd0 <__start_il2cpp@@Base+0x140db4>
 15cecc4:	a9414ffe 	ldp	x30, x19, [sp, #16]
 15cecc8:	fc4207e8 	ldr	d8, [sp], #32
 15ceccc:	d65f03c0 	ret
 15cecd0:	aa1f03e0 	mov	x0, xzr
 15cecd4:	94577ab4 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15cecd8:	bd413a61 	ldr	s1, [x19, #312]
 15cecdc:	f940e260 	ldr	x0, [x19, #448]
 15cece0:	1e212800 	fadd	s0, s0, s1
 15cece4:	bd02ea60 	str	s0, [x19, #744]
 15cece8:	b4000180 	cbz	x0, 15ced18 <__start_il2cpp@@Base+0x140dfc>
 15cecec:	1e204020 	fmov	s0, s1
 15cecf0:	aa1f03e1 	mov	x1, xzr
 15cecf4:	97ffaaab 	bl	15b97a0 <__start_il2cpp@@Base+0x12b884>
 15cecf8:	aa1303e0 	mov	x0, x19
 15cecfc:	97ffffc0 	bl	15cebfc <__start_il2cpp@@Base+0x140ce0>
 15ced00:	aa0003e1 	mov	x1, x0
 15ced04:	aa1303e0 	mov	x0, x19
 15ced08:	aa1f03e2 	mov	x2, xzr
 15ced0c:	a9414ffe 	ldp	x30, x19, [sp, #16]
 15ced10:	fc4207e8 	ldr	d8, [sp], #32
 15ced14:	14576129 	b	2ba71b8 <__start_il2cpp@@Base+0x171929c>
 15ced18:	97f73b1f 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ced1c:	d65f03c0 	ret
 15ced20:	d65f03c0 	ret
 15ced24:	a9bd5ffe 	stp	x30, x23, [sp, #-48]!
 15ced28:	a90157f6 	stp	x22, x21, [sp, #16]
 15ced2c:	a9024ff4 	stp	x20, x19, [sp, #32]
 15ced30:	f000e115 	adrp	x21, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ced34:	aa0103f3 	mov	x19, x1
 15ced38:	aa0003f4 	mov	x20, x0
 15ced3c:	3969dea8 	ldrb	w8, [x21, #2679]
 15ced40:	37000128 	tbnz	w8, #0, 15ced64 <__start_il2cpp@@Base+0x140e48>
 15ced44:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ced48:	f944c400 	ldr	x0, [x0, #2440]
 15ced4c:	97f73a80 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ced50:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ced54:	f9401c00 	ldr	x0, [x0, #56]
 15ced58:	97f73a7d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ced5c:	52800028 	mov	w8, #0x1                   	// #1
 15ced60:	3929dea8 	strb	w8, [x21, #2679]
 15ced64:	b000d195 	adrp	x21, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ced68:	394c0288 	ldrb	w8, [x20, #768]
 15ced6c:	f944c6b5 	ldr	x21, [x21, #2440]
 15ced70:	34000068 	cbz	w8, 15ced7c <__start_il2cpp@@Base+0x140e60>
 15ced74:	aa1403e0 	mov	x0, x20
 15ced78:	97ffe92b 	bl	15c9224 <__start_il2cpp@@Base+0x13b308>
 15ced7c:	f94002a1 	ldr	x1, [x21]
 15ced80:	52800036 	mov	w22, #0x1                   	// #1
ASM END

## NinjaMovementScript.Chem iterator MoveNext
- RVA: 0x15d0fcc; window: 768 bytes; objdump exit: 0; instruction rows: 192
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015d0fcc <__start_il2cpp@@Base+0x1430b0>:
 15d0fcc:	fc1c0fe8 	str	d8, [sp, #-64]!
 15d0fd0:	f90007fe 	str	x30, [sp, #8]
 15d0fd4:	a9015ff8 	stp	x24, x23, [sp, #16]
 15d0fd8:	a90257f6 	stp	x22, x21, [sp, #32]
 15d0fdc:	a9034ff4 	stp	x20, x19, [sp, #48]
 15d0fe0:	b000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d0fe4:	aa0003f3 	mov	x19, x0
 15d0fe8:	396a6288 	ldrb	w8, [x20, #2712]
 15d0fec:	37000308 	tbnz	w8, #0, 15d104c <__start_il2cpp@@Base+0x143130>
 15d0ff0:	f000d160 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15d0ff4:	f944c400 	ldr	x0, [x0, #2440]
 15d0ff8:	97f731d5 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d0ffc:	d000d160 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d1000:	f9468800 	ldr	x0, [x0, #3344]
 15d1004:	97f731d2 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1008:	9000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d100c:	f9469000 	ldr	x0, [x0, #3360]
 15d1010:	97f731cf 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1014:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1018:	f9406c00 	ldr	x0, [x0, #216]
 15d101c:	97f731cc 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1020:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1024:	f9404000 	ldr	x0, [x0, #128]
 15d1028:	97f731c9 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d102c:	9000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d1030:	f9472400 	ldr	x0, [x0, #3656]
 15d1034:	97f731c6 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1038:	b000d180 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d103c:	f9407000 	ldr	x0, [x0, #224]
 15d1040:	97f731c3 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d1044:	52800028 	mov	w8, #0x1                   	// #1
 15d1048:	392a6288 	strb	w8, [x20, #2712]
 15d104c:	b9401268 	ldr	w8, [x19, #16]
 15d1050:	f9401274 	ldr	x20, [x19, #32]
 15d1054:	7100091f 	cmp	w8, #0x2
 15d1058:	540006c0 	b.eq	15d1130 <__start_il2cpp@@Base+0x143214>  // b.none
 15d105c:	7100051f 	cmp	w8, #0x1
 15d1060:	54000280 	b.eq	15d10b0 <__start_il2cpp@@Base+0x143194>  // b.none
 15d1064:	35000a48 	cbnz	w8, 15d11ac <__start_il2cpp@@Base+0x143290>
 15d1068:	12800008 	mov	w8, #0xffffffff            	// #-1
 15d106c:	b9001268 	str	w8, [x19, #16]
 15d1070:	b4001874 	cbz	x20, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1074:	aa1f03e0 	mov	x0, xzr
 15d1078:	3909429f 	strb	wzr, [x20, #592]
 15d107c:	390f029f 	strb	wzr, [x20, #960]
 15d1080:	945771c9 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15d1084:	1e2e1001 	fmov	s1, #1.000000000000000000e+00
 15d1088:	bd437282 	ldr	s2, [x20, #880]
 15d108c:	1e212841 	fadd	s1, s2, s1
 15d1090:	1e212000 	fcmp	s0, s1
 15d1094:	5400090d 	b.le	15d11b4 <__start_il2cpp@@Base+0x143298>
 15d1098:	2a1f03e0 	mov	w0, wzr
 15d109c:	52800061 	mov	w1, #0x3                   	// #3
 15d10a0:	aa1f03e2 	mov	x2, xzr
 15d10a4:	945733c0 	bl	2b9dfa4 <__start_il2cpp@@Base+0x1710088>
 15d10a8:	b9037680 	str	w0, [x20, #884]
 15d10ac:	14000047 	b	15d11c8 <__start_il2cpp@@Base+0x1432ac>
 15d10b0:	12800008 	mov	w8, #0xffffffff            	// #-1
 15d10b4:	b9001268 	str	w8, [x19, #16]
 15d10b8:	b4001634 	cbz	x20, 15d137c <__start_il2cpp@@Base+0x143460>
 15d10bc:	394e2688 	ldrb	w8, [x20, #905]
 15d10c0:	34000188 	cbz	w8, 15d10f0 <__start_il2cpp@@Base+0x1431d4>
 15d10c4:	f9417e80 	ldr	x0, [x20, #760]
 15d10c8:	b40015a0 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d10cc:	aa1f03e1 	mov	x1, xzr
 15d10d0:	945743e6 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15d10d4:	b4001540 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d10d8:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d10dc:	52800022 	mov	w2, #0x1                   	// #1
 15d10e0:	aa1f03e3 	mov	x3, xzr
 15d10e4:	f9406d08 	ldr	x8, [x8, #216]
 15d10e8:	f9400101 	ldr	x1, [x8]
 15d10ec:	945750a2 	bl	2ba5374 <__start_il2cpp@@Base+0x1717458>
 15d10f0:	b000d168 	adrp	x8, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15d10f4:	f9468908 	ldr	x8, [x8, #3344]
 15d10f8:	bd406288 	ldr	s8, [x20, #96]
 15d10fc:	f9400100 	ldr	x0, [x8]
 15d1100:	97f73221 	bl	139d984 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb86c>
 15d1104:	b0ff8fc8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15d1108:	aa1f03e1 	mov	x1, xzr
 15d110c:	aa0003f4 	mov	x20, x0
 15d1110:	bd472900 	ldr	s0, [x8, #1832]
 15d1114:	1e202900 	fadd	s0, s8, s0
 15d1118:	94576cfd 	bl	2bac50c <__start_il2cpp@@Base+0x171e5f0>
 15d111c:	52800048 	mov	w8, #0x2                   	// #2
 15d1120:	f9000e74 	str	x20, [x19, #24]
 15d1124:	52800020 	mov	w0, #0x1                   	// #1
 15d1128:	b9001268 	str	w8, [x19, #16]
 15d112c:	1400008e 	b	15d1364 <__start_il2cpp@@Base+0x143448>
 15d1130:	12800008 	mov	w8, #0xffffffff            	// #-1
 15d1134:	b9001268 	str	w8, [x19, #16]
 15d1138:	b4001234 	cbz	x20, 15d137c <__start_il2cpp@@Base+0x143460>
 15d113c:	3946d688 	ldrb	w8, [x20, #437]
 15d1140:	34000268 	cbz	w8, 15d118c <__start_il2cpp@@Base+0x143270>
 15d1144:	d000d173 	adrp	x19, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15d1148:	aa1403e0 	mov	x0, x20
 15d114c:	f944c673 	ldr	x19, [x19, #2440]
 15d1150:	f9400261 	ldr	x1, [x19]
 15d1154:	94075fd3 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15d1158:	f9400261 	ldr	x1, [x19]
 15d115c:	aa0003f3 	mov	x19, x0
 15d1160:	aa1403e0 	mov	x0, x20
 15d1164:	94075fcf 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15d1168:	b40010a0 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d116c:	aa1f03e1 	mov	x1, xzr
 15d1170:	9458a89f 	bl	2bfb3ec <__start_il2cpp@@Base+0x176d4d0>
 15d1174:	b4001053 	cbz	x19, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1178:	2f00e400 	movi	d0, #0x0
 15d117c:	aa1303e0 	mov	x0, x19
 15d1180:	aa1f03e1 	mov	x1, xzr
 15d1184:	9458a8cd 	bl	2bfb4b8 <__start_il2cpp@@Base+0x176d59c>
 15d1188:	3906d69f 	strb	wzr, [x20, #437]
 15d118c:	f9403e80 	ldr	x0, [x20, #120]
 15d1190:	b4000f60 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1194:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1198:	2a1f03e2 	mov	w2, wzr
 15d119c:	aa1f03e3 	mov	x3, xzr
 15d11a0:	f9404108 	ldr	x8, [x8, #128]
 15d11a4:	f9400101 	ldr	x1, [x8]
 15d11a8:	94565b66 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d11ac:	2a1f03e0 	mov	w0, wzr
 15d11b0:	1400006d 	b	15d1364 <__start_il2cpp@@Base+0x143448>
 15d11b4:	b9437688 	ldr	w8, [x20, #884]
 15d11b8:	11000509 	add	w9, w8, #0x1
 15d11bc:	71000d3f 	cmp	w9, #0x3
 15d11c0:	1a88a7e8 	csinc	w8, wzr, w8, ge	// ge = tcont
 15d11c4:	b9037688 	str	w8, [x20, #884]
 15d11c8:	aa1f03e0 	mov	x0, xzr
 15d11cc:	94577176 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15d11d0:	f9403e80 	ldr	x0, [x20, #120]
 15d11d4:	bd037280 	str	s0, [x20, #880]
 15d11d8:	390ee29f 	strb	wzr, [x20, #952]
 15d11dc:	b4000d00 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d11e0:	9000d188 	adrp	x8, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d11e4:	2a1f03e2 	mov	w2, wzr
 15d11e8:	aa1f03e3 	mov	x3, xzr
 15d11ec:	f9472508 	ldr	x8, [x8, #3656]
 15d11f0:	f9400101 	ldr	x1, [x8]
 15d11f4:	94565b53 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d11f8:	f9403e80 	ldr	x0, [x20, #120]
 15d11fc:	b4000c00 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1200:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1204:	52800022 	mov	w2, #0x1                   	// #1
 15d1208:	aa1f03e3 	mov	x3, xzr
 15d120c:	f9404108 	ldr	x8, [x8, #128]
 15d1210:	f9400101 	ldr	x1, [x8]
 15d1214:	94565b4b 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15d1218:	f9403e80 	ldr	x0, [x20, #120]
 15d121c:	b4000b00 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1220:	b000d188 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15d1224:	aa1f03e3 	mov	x3, xzr
 15d1228:	f9407108 	ldr	x8, [x8, #224]
 15d122c:	b9437682 	ldr	w2, [x20, #884]
 15d1230:	f9400101 	ldr	x1, [x8]
 15d1234:	94565bb0 	bl	2b680f4 <__start_il2cpp@@Base+0x16da1d8>
 15d1238:	f9403e80 	ldr	x0, [x20, #120]
 15d123c:	b4000a00 	cbz	x0, 15d137c <__start_il2cpp@@Base+0x143460>
 15d1240:	9000d188 	adrp	x8, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d1244:	aa1f03e2 	mov	x2, xzr
 15d1248:	f9469108 	ldr	x8, [x8, #3360]
 15d124c:	f9400101 	ldr	x1, [x8]
 15d1250:	94565c16 	bl	2b682a8 <__start_il2cpp@@Base+0x16da38c>
 15d1254:	d000d176 	adrp	x22, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
ASM END

## NinjaMovementScript.PhiMoc
- RVA: 0x15ced24; window: 384 bytes; objdump exit: 0; instruction rows: 96
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ced24 <__start_il2cpp@@Base+0x140e08>:
 15ced24:	a9bd5ffe 	stp	x30, x23, [sp, #-48]!
 15ced28:	a90157f6 	stp	x22, x21, [sp, #16]
 15ced2c:	a9024ff4 	stp	x20, x19, [sp, #32]
 15ced30:	f000e115 	adrp	x21, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ced34:	aa0103f3 	mov	x19, x1
 15ced38:	aa0003f4 	mov	x20, x0
 15ced3c:	3969dea8 	ldrb	w8, [x21, #2679]
 15ced40:	37000128 	tbnz	w8, #0, 15ced64 <__start_il2cpp@@Base+0x140e48>
 15ced44:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ced48:	f944c400 	ldr	x0, [x0, #2440]
 15ced4c:	97f73a80 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ced50:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ced54:	f9401c00 	ldr	x0, [x0, #56]
 15ced58:	97f73a7d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ced5c:	52800028 	mov	w8, #0x1                   	// #1
 15ced60:	3929dea8 	strb	w8, [x21, #2679]
 15ced64:	b000d195 	adrp	x21, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ced68:	394c0288 	ldrb	w8, [x20, #768]
 15ced6c:	f944c6b5 	ldr	x21, [x21, #2440]
 15ced70:	34000068 	cbz	w8, 15ced7c <__start_il2cpp@@Base+0x140e60>
 15ced74:	aa1403e0 	mov	x0, x20
 15ced78:	97ffe92b 	bl	15c9224 <__start_il2cpp@@Base+0x13b308>
 15ced7c:	f94002a1 	ldr	x1, [x21]
 15ced80:	52800036 	mov	w22, #0x1                   	// #1
 15ced84:	aa1403e0 	mov	x0, x20
 15ced88:	3906b29f 	strb	wzr, [x20, #428]
 15ced8c:	39094696 	strb	w22, [x20, #593]
 15ced90:	940768c4 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15ced94:	f000e117 	adrp	x23, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ced98:	aa0003f5 	mov	x21, x0
 15ced9c:	394c5ae8 	ldrb	w8, [x23, #790]
 15ceda0:	350000a8 	cbnz	w8, 15cedb4 <__start_il2cpp@@Base+0x140e98>
 15ceda4:	9000d180 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15ceda8:	f944f000 	ldr	x0, [x0, #2528]
 15cedac:	97f73a68 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cedb0:	390c5af6 	strb	w22, [x23, #790]
 15cedb4:	b4000375 	cbz	x21, 15cee20 <__start_il2cpp@@Base+0x140f04>
 15cedb8:	9000d188 	adrp	x8, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15cedbc:	aa1503e0 	mov	x0, x21
 15cedc0:	aa1f03e1 	mov	x1, xzr
 15cedc4:	f944f108 	ldr	x8, [x8, #2528]
 15cedc8:	f9400108 	ldr	x8, [x8]
 15cedcc:	f9405d08 	ldr	x8, [x8, #184]
 15cedd0:	2d400500 	ldp	s0, s1, [x8]
 15cedd4:	9458b1b9 	bl	2bfb4b8 <__start_il2cpp@@Base+0x176d59c>
 15cedd8:	f9403e80 	ldr	x0, [x20, #120]
 15ceddc:	b4000220 	cbz	x0, 15cee20 <__start_il2cpp@@Base+0x140f04>
 15cede0:	9000d1a8 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cede4:	aa1f03e2 	mov	x2, xzr
 15cede8:	f9401d08 	ldr	x8, [x8, #56]
 15cedec:	f9400101 	ldr	x1, [x8]
 15cedf0:	9456652e 	bl	2b682a8 <__start_il2cpp@@Base+0x16da38c>
 15cedf4:	f940ea80 	ldr	x0, [x20, #464]
 15cedf8:	b4000140 	cbz	x0, 15cee20 <__start_il2cpp@@Base+0x140f04>
 15cedfc:	aa1f03e1 	mov	x1, xzr
 15cee00:	97fd5928 	bl	15252a0 <__start_il2cpp@@Base+0x97384>
 15cee04:	f9426680 	ldr	x0, [x20, #1224]
 15cee08:	b40000c0 	cbz	x0, 15cee20 <__start_il2cpp@@Base+0x140f04>
 15cee0c:	aa1303e1 	mov	x1, x19
 15cee10:	a9424ff4 	ldp	x20, x19, [sp, #32]
 15cee14:	a94157f6 	ldp	x22, x21, [sp, #16]
 15cee18:	a8c35ffe 	ldp	x30, x23, [sp], #48
 15cee1c:	17ffdb76 	b	15c5bf4 <__start_il2cpp@@Base+0x137cd8>
 15cee20:	97f73add 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15cee24:	fc1c0fe8 	str	d8, [sp, #-64]!
 15cee28:	a9015ffe 	stp	x30, x23, [sp, #16]
 15cee2c:	a90257f6 	stp	x22, x21, [sp, #32]
 15cee30:	a9034ff4 	stp	x20, x19, [sp, #48]
 15cee34:	f000e117 	adrp	x23, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15cee38:	aa0303f4 	mov	x20, x3
 15cee3c:	aa0203f5 	mov	x21, x2
 15cee40:	3969e2e8 	ldrb	w8, [x23, #2680]
 15cee44:	aa0103f6 	mov	x22, x1
 15cee48:	aa0003f3 	mov	x19, x0
 15cee4c:	37000128 	tbnz	w8, #0, 15cee70 <__start_il2cpp@@Base+0x140f54>
 15cee50:	f000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15cee54:	f9472c00 	ldr	x0, [x0, #3672]
 15cee58:	97f73a3d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cee5c:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cee60:	f9402000 	ldr	x0, [x0, #64]
 15cee64:	97f73a3a 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cee68:	52800028 	mov	w8, #0x1                   	// #1
 15cee6c:	3929e2e8 	strb	w8, [x23, #2680]
 15cee70:	f9418668 	ldr	x8, [x19, #776]
 15cee74:	b4000828 	cbz	x8, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cee78:	bd439e60 	ldr	s0, [x19, #924]
 15cee7c:	f9403e60 	ldr	x0, [x19, #120]
 15cee80:	f9026a76 	str	x22, [x19, #1232]
 15cee84:	f9026e75 	str	x21, [x19, #1240]
 15cee88:	bd003900 	str	s0, [x8, #56]
 15cee8c:	52800028 	mov	w8, #0x1                   	// #1
 15cee90:	f9027a74 	str	x20, [x19, #1264]
 15cee94:	3909467f 	strb	wzr, [x19, #593]
 15cee98:	3906da68 	strb	w8, [x19, #438]
 15cee9c:	390d1668 	strb	w8, [x19, #837]
 15ceea0:	b40006c0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
ASM END

## NinjaMovementScript.BayToPoint
- RVA: 0x15cee24; window: 544 bytes; objdump exit: 0; instruction rows: 136
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015cee24 <__start_il2cpp@@Base+0x140f08>:
 15cee24:	fc1c0fe8 	str	d8, [sp, #-64]!
 15cee28:	a9015ffe 	stp	x30, x23, [sp, #16]
 15cee2c:	a90257f6 	stp	x22, x21, [sp, #32]
 15cee30:	a9034ff4 	stp	x20, x19, [sp, #48]
 15cee34:	f000e117 	adrp	x23, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15cee38:	aa0303f4 	mov	x20, x3
 15cee3c:	aa0203f5 	mov	x21, x2
 15cee40:	3969e2e8 	ldrb	w8, [x23, #2680]
 15cee44:	aa0103f6 	mov	x22, x1
 15cee48:	aa0003f3 	mov	x19, x0
 15cee4c:	37000128 	tbnz	w8, #0, 15cee70 <__start_il2cpp@@Base+0x140f54>
 15cee50:	f000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15cee54:	f9472c00 	ldr	x0, [x0, #3672]
 15cee58:	97f73a3d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cee5c:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cee60:	f9402000 	ldr	x0, [x0, #64]
 15cee64:	97f73a3a 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cee68:	52800028 	mov	w8, #0x1                   	// #1
 15cee6c:	3929e2e8 	strb	w8, [x23, #2680]
 15cee70:	f9418668 	ldr	x8, [x19, #776]
 15cee74:	b4000828 	cbz	x8, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cee78:	bd439e60 	ldr	s0, [x19, #924]
 15cee7c:	f9403e60 	ldr	x0, [x19, #120]
 15cee80:	f9026a76 	str	x22, [x19, #1232]
 15cee84:	f9026e75 	str	x21, [x19, #1240]
 15cee88:	bd003900 	str	s0, [x8, #56]
 15cee8c:	52800028 	mov	w8, #0x1                   	// #1
 15cee90:	f9027a74 	str	x20, [x19, #1264]
 15cee94:	3909467f 	strb	wzr, [x19, #593]
 15cee98:	3906da68 	strb	w8, [x19, #438]
 15cee9c:	390d1668 	strb	w8, [x19, #837]
 15ceea0:	b40006c0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15ceea4:	9000d1a8 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ceea8:	aa1f03e2 	mov	x2, xzr
 15ceeac:	f9402108 	ldr	x8, [x8, #64]
 15ceeb0:	f9400101 	ldr	x1, [x8]
 15ceeb4:	945664fd 	bl	2b682a8 <__start_il2cpp@@Base+0x16da38c>
 15ceeb8:	f9403e60 	ldr	x0, [x19, #120]
 15ceebc:	b40005e0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15ceec0:	f000d188 	adrp	x8, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15ceec4:	52800022 	mov	w2, #0x1                   	// #1
 15ceec8:	aa1f03e3 	mov	x3, xzr
 15ceecc:	f9472d08 	ldr	x8, [x8, #3672]
 15ceed0:	f9400101 	ldr	x1, [x8]
 15ceed4:	9456641b 	bl	2b67f40 <__start_il2cpp@@Base+0x16da024>
 15ceed8:	f940ea60 	ldr	x0, [x19, #464]
 15ceedc:	b40004e0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15ceee0:	aa1f03e1 	mov	x1, xzr
 15ceee4:	97fd591b 	bl	1525350 <__start_il2cpp@@Base+0x97434>
 15ceee8:	f9426e60 	ldr	x0, [x19, #1240]
 15ceeec:	b4000460 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15ceef0:	aa1f03e1 	mov	x1, xzr
 15ceef4:	94578690 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15ceef8:	b4000414 	cbz	x20, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15ceefc:	aa1403e0 	mov	x0, x20
 15cef00:	aa1f03e1 	mov	x1, xzr
 15cef04:	1e204008 	fmov	s8, s0
 15cef08:	9457868b 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15cef0c:	1e202100 	fcmp	s8, s0
 15cef10:	54000145 	b.pl	15cef38 <__start_il2cpp@@Base+0x14101c>  // b.nfrst
 15cef14:	f9412e60 	ldr	x0, [x19, #600]
 15cef18:	3907fa7f 	strb	wzr, [x19, #510]
 15cef1c:	b40002e0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cef20:	aa1f03e1 	mov	x1, xzr
 15cef24:	945759b2 	bl	2ba55ec <__start_il2cpp@@Base+0x17176d0>
 15cef28:	b4000280 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cef2c:	bd426260 	ldr	s0, [x19, #608]
 15cef30:	1e214000 	fneg	s0, s0
 15cef34:	14000009 	b	15cef58 <__start_il2cpp@@Base+0x14103c>
 15cef38:	f9412e60 	ldr	x0, [x19, #600]
 15cef3c:	52800028 	mov	w8, #0x1                   	// #1
 15cef40:	3907fa68 	strb	w8, [x19, #510]
 15cef44:	b40001a0 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cef48:	aa1f03e1 	mov	x1, xzr
 15cef4c:	945759a8 	bl	2ba55ec <__start_il2cpp@@Base+0x17176d0>
 15cef50:	b4000140 	cbz	x0, 15cef78 <__start_il2cpp@@Base+0x14105c>
 15cef54:	bd426260 	ldr	s0, [x19, #608]
 15cef58:	bd426a62 	ldr	s2, [x19, #616]
 15cef5c:	bd426661 	ldr	s1, [x19, #612]
 15cef60:	aa1f03e1 	mov	x1, xzr
 15cef64:	a9434ff4 	ldp	x20, x19, [sp, #48]
 15cef68:	a94257f6 	ldp	x22, x21, [sp, #32]
 15cef6c:	a9415ffe 	ldp	x30, x23, [sp, #16]
 15cef70:	fc4407e8 	ldr	d8, [sp], #64
 15cef74:	145788ab 	b	2bb1220 <__start_il2cpp@@Base+0x1723304>
 15cef78:	97f73a87 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15cef7c:	d65f03c0 	ret
 15cef80:	f940e800 	ldr	x0, [x0, #464]
 15cef84:	b4000060 	cbz	x0, 15cef90 <__start_il2cpp@@Base+0x141074>
 15cef88:	aa1f03e1 	mov	x1, xzr
 15cef8c:	17fd5917 	b	15253e8 <__start_il2cpp@@Base+0x974cc>
 15cef90:	f81f0ffe 	str	x30, [sp, #-16]!
 15cef94:	97f73a80 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15cef98:	f81e0ffe 	str	x30, [sp, #-32]!
 15cef9c:	a9014ff4 	stp	x20, x19, [sp, #16]
 15cefa0:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15cefa4:	aa0003f3 	mov	x19, x0
 15cefa8:	3969e688 	ldrb	w8, [x20, #2681]
 15cefac:	37000128 	tbnz	w8, #0, 15cefd0 <__start_il2cpp@@Base+0x1410b4>
 15cefb0:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cefb4:	f9402400 	ldr	x0, [x0, #72]
 15cefb8:	97f739e5 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cefbc:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cefc0:	f9402000 	ldr	x0, [x0, #64]
 15cefc4:	97f739e2 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cefc8:	52800028 	mov	w8, #0x1                   	// #1
 15cefcc:	3929e688 	strb	w8, [x20, #2681]
 15cefd0:	f9427a60 	ldr	x0, [x19, #1264]
 15cefd4:	b40001e0 	cbz	x0, 15cf010 <__start_il2cpp@@Base+0x1410f4>
 15cefd8:	9000d1a8 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cefdc:	aa1f03e2 	mov	x2, xzr
 15cefe0:	f9402508 	ldr	x8, [x8, #72]
 15cefe4:	f9400101 	ldr	x1, [x8]
 15cefe8:	94574f4a 	bl	2ba2d10 <__start_il2cpp@@Base+0x1714df4>
 15cefec:	f9403e60 	ldr	x0, [x19, #120]
 15ceff0:	b4000100 	cbz	x0, 15cf010 <__start_il2cpp@@Base+0x1410f4>
 15ceff4:	9000d1a8 	adrp	x8, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ceff8:	aa1f03e2 	mov	x2, xzr
 15ceffc:	f9402108 	ldr	x8, [x8, #64]
 15cf000:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15cf004:	f9400101 	ldr	x1, [x8]
 15cf008:	f84207fe 	ldr	x30, [sp], #32
 15cf00c:	1456650f 	b	2b68448 <__start_il2cpp@@Base+0x16da52c>
 15cf010:	97f73a61 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15cf014:	f81e0ffe 	str	x30, [sp, #-32]!
 15cf018:	a9014ff4 	stp	x20, x19, [sp, #16]
 15cf01c:	d000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15cf020:	aa0003f3 	mov	x19, x0
 15cf024:	3969ea88 	ldrb	w8, [x20, #2682]
 15cf028:	37000128 	tbnz	w8, #0, 15cf04c <__start_il2cpp@@Base+0x141130>
 15cf02c:	d000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15cf030:	f9472c00 	ldr	x0, [x0, #3672]
 15cf034:	97f739c6 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cf038:	d000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15cf03c:	f9473800 	ldr	x0, [x0, #3696]
 15cf040:	97f739c3 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
ASM END

## NinjaMovementScript.DauBonEmDay
- RVA: 0x15ce438; window: 544 bytes; objdump exit: 0; instruction rows: 136
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce438 <__start_il2cpp@@Base+0x14051c>:
 15ce438:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15ce43c:	a9014ff4 	stp	x20, x19, [sp, #16]
 15ce440:	3947f808 	ldrb	w8, [x0, #510]
 15ce444:	aa0003f4 	mov	x20, x0
 15ce448:	aa0103f3 	mov	x19, x1
 15ce44c:	f9024802 	str	x2, [x0, #1168]
 15ce450:	f9024c03 	str	x3, [x0, #1176]
 15ce454:	34000088 	cbz	w8, 15ce464 <__start_il2cpp@@Base+0x140548>
 15ce458:	36000084 	tbz	w4, #0, 15ce468 <__start_il2cpp@@Base+0x14054c>
 15ce45c:	f9425680 	ldr	x0, [x20, #1192]
 15ce460:	14000021 	b	15ce4e4 <__start_il2cpp@@Base+0x1405c8>
 15ce464:	360003e4 	tbz	w4, #0, 15ce4e0 <__start_il2cpp@@Base+0x1405c4>
 15ce468:	b944ba89 	ldr	w9, [x20, #1208]
 15ce46c:	b944b688 	ldr	w8, [x20, #1204]
 15ce470:	5280002a 	mov	w10, #0x1                   	// #1
 15ce474:	3912c28a 	strb	w10, [x20, #1200]
 15ce478:	6b08013f 	cmp	w9, w8
 15ce47c:	540001e1 	b.ne	15ce4b8 <__start_il2cpp@@Base+0x14059c>  // b.any
 15ce480:	52800055 	mov	w21, #0x2                   	// #2
 15ce484:	52800020 	mov	w0, #0x1                   	// #1
 15ce488:	52800c81 	mov	w1, #0x64                  	// #100
 15ce48c:	aa1f03e2 	mov	x2, xzr
 15ce490:	94573ec5 	bl	2b9dfa4 <__start_il2cpp@@Base+0x1710088>
 15ce494:	7101181f 	cmp	w0, #0x46
 15ce498:	b944ba89 	ldr	w9, [x20, #1208]
 15ce49c:	b904be80 	str	w0, [x20, #1212]
 15ce4a0:	1a9596a8 	cinc	w8, w21, hi	// hi = pmore
 15ce4a4:	7100781f 	cmp	w0, #0x1e
 15ce4a8:	1a9fc508 	csinc	w8, w8, wzr, gt
 15ce4ac:	6b08013f 	cmp	w9, w8
 15ce4b0:	b904b688 	str	w8, [x20, #1204]
 15ce4b4:	54fffe80 	b.eq	15ce484 <__start_il2cpp@@Base+0x140568>  // b.none
 15ce4b8:	3947fa89 	ldrb	w9, [x20, #510]
 15ce4bc:	7100091f 	cmp	w8, #0x2
 15ce4c0:	b904ba88 	str	w8, [x20, #1208]
 15ce4c4:	54000280 	b.eq	15ce514 <__start_il2cpp@@Base+0x1405f8>  // b.none
 15ce4c8:	7100051f 	cmp	w8, #0x1
 15ce4cc:	540002c1 	b.ne	15ce524 <__start_il2cpp@@Base+0x140608>  // b.any
 15ce4d0:	34000329 	cbz	w9, 15ce534 <__start_il2cpp@@Base+0x140618>
 15ce4d4:	f9425680 	ldr	x0, [x20, #1192]
 15ce4d8:	b5000320 	cbnz	x0, 15ce53c <__start_il2cpp@@Base+0x140620>
 15ce4dc:	1400002b 	b	15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce4e0:	f9425280 	ldr	x0, [x20, #1184]
 15ce4e4:	3912c29f 	strb	wzr, [x20, #1200]
 15ce4e8:	b4000500 	cbz	x0, 15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce4ec:	aa1303e1 	mov	x1, x19
 15ce4f0:	52800023 	mov	w3, #0x1                   	// #1
 15ce4f4:	aa1f03e4 	mov	x4, xzr
 15ce4f8:	97ff7bcc 	bl	15ad428 <__start_il2cpp@@Base+0x11f50c>
 15ce4fc:	9112d288 	add	x8, x20, #0x4b4
 15ce500:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15ce504:	b20003e9 	mov	x9, #0x100000001           	// #4294967297
 15ce508:	f9000109 	str	x9, [x8]
 15ce50c:	a8c257fe 	ldp	x30, x21, [sp], #32
 15ce510:	d65f03c0 	ret
 15ce514:	340001c9 	cbz	w9, 15ce54c <__start_il2cpp@@Base+0x140630>
 15ce518:	f9425680 	ldr	x0, [x20, #1192]
 15ce51c:	b50001c0 	cbnz	x0, 15ce554 <__start_il2cpp@@Base+0x140638>
 15ce520:	1400001a 	b	15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce524:	34000209 	cbz	w9, 15ce564 <__start_il2cpp@@Base+0x140648>
 15ce528:	f9425680 	ldr	x0, [x20, #1192]
 15ce52c:	b5000200 	cbnz	x0, 15ce56c <__start_il2cpp@@Base+0x140650>
 15ce530:	14000016 	b	15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce534:	f9425280 	ldr	x0, [x20, #1184]
 15ce538:	b4000280 	cbz	x0, 15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce53c:	f9424a82 	ldr	x2, [x20, #1168]
 15ce540:	aa1303e1 	mov	x1, x19
 15ce544:	52800023 	mov	w3, #0x1                   	// #1
 15ce548:	1400000c 	b	15ce578 <__start_il2cpp@@Base+0x14065c>
 15ce54c:	f9425280 	ldr	x0, [x20, #1184]
 15ce550:	b40001c0 	cbz	x0, 15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce554:	f9424e82 	ldr	x2, [x20, #1176]
 15ce558:	aa1303e1 	mov	x1, x19
 15ce55c:	52800043 	mov	w3, #0x2                   	// #2
 15ce560:	14000006 	b	15ce578 <__start_il2cpp@@Base+0x14065c>
 15ce564:	f9425280 	ldr	x0, [x20, #1184]
 15ce568:	b4000100 	cbz	x0, 15ce588 <__start_il2cpp@@Base+0x14066c>
 15ce56c:	f9424a82 	ldr	x2, [x20, #1168]
 15ce570:	aa1303e1 	mov	x1, x19
 15ce574:	52800063 	mov	w3, #0x3                   	// #3
 15ce578:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15ce57c:	aa1f03e4 	mov	x4, xzr
 15ce580:	a8c257fe 	ldp	x30, x21, [sp], #32
 15ce584:	17ff7ba9 	b	15ad428 <__start_il2cpp@@Base+0x11f50c>
 15ce588:	97f73d03 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce58c:	f81f0ffe 	str	x30, [sp, #-16]!
 15ce590:	3947f808 	ldrb	w8, [x0, #510]
 15ce594:	f9024802 	str	x2, [x0, #1168]
 15ce598:	f9024c03 	str	x3, [x0, #1176]
 15ce59c:	34000108 	cbz	w8, 15ce5bc <__start_il2cpp@@Base+0x1406a0>
 15ce5a0:	f9425400 	ldr	x0, [x0, #1192]
 15ce5a4:	b4000100 	cbz	x0, 15ce5c4 <__start_il2cpp@@Base+0x1406a8>
 15ce5a8:	aa0303e2 	mov	x2, x3
 15ce5ac:	52800043 	mov	w3, #0x2                   	// #2
 15ce5b0:	aa1f03e4 	mov	x4, xzr
 15ce5b4:	f84107fe 	ldr	x30, [sp], #16
 15ce5b8:	17ff7b9c 	b	15ad428 <__start_il2cpp@@Base+0x11f50c>
 15ce5bc:	f9425000 	ldr	x0, [x0, #1184]
 15ce5c0:	b5ffff40 	cbnz	x0, 15ce5a8 <__start_il2cpp@@Base+0x14068c>
 15ce5c4:	97f73cf4 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce5c8:	6dbd23e9 	stp	d9, d8, [sp, #-48]!
 15ce5cc:	a90157fe 	stp	x30, x21, [sp, #16]
 15ce5d0:	a9024ff4 	stp	x20, x19, [sp, #32]
 15ce5d4:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce5d8:	aa0003f3 	mov	x19, x0
 15ce5dc:	3969c688 	ldrb	w8, [x20, #2673]
 15ce5e0:	370000c8 	tbnz	w8, #0, 15ce5f8 <__start_il2cpp@@Base+0x1406dc>
 15ce5e4:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce5e8:	f944c400 	ldr	x0, [x0, #2440]
 15ce5ec:	97f73c58 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce5f0:	52800028 	mov	w8, #0x1                   	// #1
 15ce5f4:	3929c688 	strb	w8, [x20, #2673]
 15ce5f8:	bd42ee68 	ldr	s8, [x19, #748]
 15ce5fc:	aa1f03e0 	mov	x0, xzr
 15ce600:	94577c69 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce604:	1e202100 	fcmp	s8, s0
 15ce608:	540000a9 	b.ls	15ce61c <__start_il2cpp@@Base+0x140700>  // b.plast
 15ce60c:	a9424ff4 	ldp	x20, x19, [sp, #32]
 15ce610:	a94157fe 	ldp	x30, x21, [sp, #16]
 15ce614:	6cc323e9 	ldp	d9, d8, [sp], #48
 15ce618:	d65f03c0 	ret
 15ce61c:	f9415274 	ldr	x20, [x19, #672]
 15ce620:	aa1303e0 	mov	x0, x19
 15ce624:	aa1f03e1 	mov	x1, xzr
 15ce628:	94574e90 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce62c:	b4000f00 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce630:	aa1f03e1 	mov	x1, xzr
 15ce634:	94575bee 	bl	2ba55ec <__start_il2cpp@@Base+0x17176d0>
 15ce638:	b4000ea0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce63c:	aa1f03e1 	mov	x1, xzr
 15ce640:	945788bd 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15ce644:	b4000e54 	cbz	x20, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce648:	aa1403e0 	mov	x0, x20
 15ce64c:	aa1f03e1 	mov	x1, xzr
 15ce650:	97fd6ae2 	bl	15291d8 <__start_il2cpp@@Base+0x9b2bc>
 15ce654:	bd403e60 	ldr	s0, [x19, #60]
ASM END

## NinjaMovementScript.DauBonEmDay2
- RVA: 0x15ce58c; window: 384 bytes; objdump exit: 0; instruction rows: 96
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce58c <__start_il2cpp@@Base+0x140670>:
 15ce58c:	f81f0ffe 	str	x30, [sp, #-16]!
 15ce590:	3947f808 	ldrb	w8, [x0, #510]
 15ce594:	f9024802 	str	x2, [x0, #1168]
 15ce598:	f9024c03 	str	x3, [x0, #1176]
 15ce59c:	34000108 	cbz	w8, 15ce5bc <__start_il2cpp@@Base+0x1406a0>
 15ce5a0:	f9425400 	ldr	x0, [x0, #1192]
 15ce5a4:	b4000100 	cbz	x0, 15ce5c4 <__start_il2cpp@@Base+0x1406a8>
 15ce5a8:	aa0303e2 	mov	x2, x3
 15ce5ac:	52800043 	mov	w3, #0x2                   	// #2
 15ce5b0:	aa1f03e4 	mov	x4, xzr
 15ce5b4:	f84107fe 	ldr	x30, [sp], #16
 15ce5b8:	17ff7b9c 	b	15ad428 <__start_il2cpp@@Base+0x11f50c>
 15ce5bc:	f9425000 	ldr	x0, [x0, #1184]
 15ce5c0:	b5ffff40 	cbnz	x0, 15ce5a8 <__start_il2cpp@@Base+0x14068c>
 15ce5c4:	97f73cf4 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15ce5c8:	6dbd23e9 	stp	d9, d8, [sp, #-48]!
 15ce5cc:	a90157fe 	stp	x30, x21, [sp, #16]
 15ce5d0:	a9024ff4 	stp	x20, x19, [sp, #32]
 15ce5d4:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce5d8:	aa0003f3 	mov	x19, x0
 15ce5dc:	3969c688 	ldrb	w8, [x20, #2673]
 15ce5e0:	370000c8 	tbnz	w8, #0, 15ce5f8 <__start_il2cpp@@Base+0x1406dc>
 15ce5e4:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce5e8:	f944c400 	ldr	x0, [x0, #2440]
 15ce5ec:	97f73c58 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce5f0:	52800028 	mov	w8, #0x1                   	// #1
 15ce5f4:	3929c688 	strb	w8, [x20, #2673]
 15ce5f8:	bd42ee68 	ldr	s8, [x19, #748]
 15ce5fc:	aa1f03e0 	mov	x0, xzr
 15ce600:	94577c69 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce604:	1e202100 	fcmp	s8, s0
 15ce608:	540000a9 	b.ls	15ce61c <__start_il2cpp@@Base+0x140700>  // b.plast
 15ce60c:	a9424ff4 	ldp	x20, x19, [sp, #32]
 15ce610:	a94157fe 	ldp	x30, x21, [sp, #16]
 15ce614:	6cc323e9 	ldp	d9, d8, [sp], #48
 15ce618:	d65f03c0 	ret
 15ce61c:	f9415274 	ldr	x20, [x19, #672]
 15ce620:	aa1303e0 	mov	x0, x19
 15ce624:	aa1f03e1 	mov	x1, xzr
 15ce628:	94574e90 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce62c:	b4000f00 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce630:	aa1f03e1 	mov	x1, xzr
 15ce634:	94575bee 	bl	2ba55ec <__start_il2cpp@@Base+0x17176d0>
 15ce638:	b4000ea0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce63c:	aa1f03e1 	mov	x1, xzr
 15ce640:	945788bd 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15ce644:	b4000e54 	cbz	x20, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce648:	aa1403e0 	mov	x0, x20
 15ce64c:	aa1f03e1 	mov	x1, xzr
 15ce650:	97fd6ae2 	bl	15291d8 <__start_il2cpp@@Base+0x9b2bc>
 15ce654:	bd403e60 	ldr	s0, [x19, #60]
 15ce658:	f940e268 	ldr	x8, [x19, #448]
 15ce65c:	bd002660 	str	s0, [x19, #36]
 15ce660:	b4000d68 	cbz	x8, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce664:	394fc509 	ldrb	w9, [x8, #1009]
 15ce668:	394df514 	ldrb	w20, [x8, #893]
 15ce66c:	34000149 	cbz	w9, 15ce694 <__start_il2cpp@@Base+0x140778>
 15ce670:	394fc915 	ldrb	w21, [x8, #1010]
 15ce674:	bd415269 	ldr	s9, [x19, #336]
 15ce678:	aa1f03e0 	mov	x0, xzr
 15ce67c:	94577c4a 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce680:	340001d4 	cbz	w20, 15ce6b8 <__start_il2cpp@@Base+0x14079c>
 15ce684:	34000155 	cbz	w21, 15ce6ac <__start_il2cpp@@Base+0x140790>
 15ce688:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce68c:	bd46bd08 	ldr	s8, [x8, #1724]
 15ce690:	1400000d 	b	15ce6c4 <__start_il2cpp@@Base+0x1407a8>
 15ce694:	34000314 	cbz	w20, 15ce6f4 <__start_il2cpp@@Base+0x1407d8>
 15ce698:	394fc914 	ldrb	w20, [x8, #1010]
 15ce69c:	bd415269 	ldr	s9, [x19, #336]
 15ce6a0:	aa1f03e0 	mov	x0, xzr
 15ce6a4:	94577c40 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce6a8:	340000b4 	cbz	w20, 15ce6bc <__start_il2cpp@@Base+0x1407a0>
 15ce6ac:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce6b0:	bd457d08 	ldr	s8, [x8, #1404]
 15ce6b4:	14000004 	b	15ce6c4 <__start_il2cpp@@Base+0x1407a8>
 15ce6b8:	35ffffb5 	cbnz	w21, 15ce6ac <__start_il2cpp@@Base+0x140790>
 15ce6bc:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15ce6c0:	bd456908 	ldr	s8, [x8, #1384]
 15ce6c4:	1e282800 	fadd	s0, s0, s8
 15ce6c8:	1e202120 	fcmp	s9, s0
 15ce6cc:	54000145 	b.pl	15ce6f4 <__start_il2cpp@@Base+0x1407d8>  // b.nfrst
 15ce6d0:	aa1f03e0 	mov	x0, xzr
 15ce6d4:	94577c34 	bl	2bad7a4 <__start_il2cpp@@Base+0x171f888>
 15ce6d8:	1e282800 	fadd	s0, s0, s8
 15ce6dc:	f9415260 	ldr	x0, [x19, #672]
 15ce6e0:	bd015260 	str	s0, [x19, #336]
 15ce6e4:	b4000940 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce6e8:	1e204100 	fmov	s0, s8
 15ce6ec:	aa1f03e1 	mov	x1, xzr
 15ce6f0:	97fd6ea5 	bl	152a184 <__start_il2cpp@@Base+0x9c268>
 15ce6f4:	f9408260 	ldr	x0, [x19, #256]
 15ce6f8:	b40008a0 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce6fc:	aa1f03e1 	mov	x1, xzr
 15ce700:	94574e5a 	bl	2ba2068 <__start_il2cpp@@Base+0x171414c>
 15ce704:	b4000840 	cbz	x0, 15ce80c <__start_il2cpp@@Base+0x1408f0>
 15ce708:	52800021 	mov	w1, #0x1                   	// #1
ASM END

## PlayerDash.ShowGhost
- RVA: 0x15d34a8; window: 384 bytes; objdump exit: 0; instruction rows: 96
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015d34a8 <__start_il2cpp@@Base+0x14558c>:
 15d34a8:	a9be57fe 	stp	x30, x21, [sp, #-32]!
 15d34ac:	a9014ff4 	stp	x20, x19, [sp, #16]
 15d34b0:	d000e0f5 	adrp	x21, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d34b4:	2a0103f4 	mov	w20, w1
 15d34b8:	aa0003f3 	mov	x19, x0
 15d34bc:	396aaea8 	ldrb	w8, [x21, #2731]
 15d34c0:	37000128 	tbnz	w8, #0, 15d34e4 <__start_il2cpp@@Base+0x1455c8>
 15d34c4:	b000d160 	adrp	x0, 3000000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x4738>
 15d34c8:	f9475400 	ldr	x0, [x0, #3752]
 15d34cc:	97f728a0 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d34d0:	d000d160 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d34d4:	f943d400 	ldr	x0, [x0, #1960]
 15d34d8:	97f7289d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d34dc:	52800028 	mov	w8, #0x1                   	// #1
 15d34e0:	392aaea8 	strb	w8, [x21, #2731]
 15d34e4:	f9401668 	ldr	x8, [x19, #40]
 15d34e8:	b40007e8 	cbz	x8, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d34ec:	3947f909 	ldrb	w9, [x8, #510]
 15d34f0:	f9401268 	ldr	x8, [x19, #32]
 15d34f4:	34000149 	cbz	w9, 15d351c <__start_il2cpp@@Base+0x145600>
 15d34f8:	b4000768 	cbz	x8, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d34fc:	b9401909 	ldr	w9, [x8, #24]
 15d3500:	6b14013f 	cmp	w9, w20
 15d3504:	54000729 	b.ls	15d35e8 <__start_il2cpp@@Base+0x1456cc>  // b.plast
 15d3508:	8b34cd08 	add	x8, x8, w20, sxtw #3
 15d350c:	f9401100 	ldr	x0, [x8, #32]
 15d3510:	b40006a0 	cbz	x0, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3514:	1e2e1000 	fmov	s0, #1.000000000000000000e+00
 15d3518:	14000009 	b	15d353c <__start_il2cpp@@Base+0x145620>
 15d351c:	b4000648 	cbz	x8, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3520:	b9401909 	ldr	w9, [x8, #24]
 15d3524:	6b14013f 	cmp	w9, w20
 15d3528:	54000609 	b.ls	15d35e8 <__start_il2cpp@@Base+0x1456cc>  // b.plast
 15d352c:	8b34cd08 	add	x8, x8, w20, sxtw #3
 15d3530:	f9401100 	ldr	x0, [x8, #32]
 15d3534:	b4000580 	cbz	x0, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3538:	1e3e1000 	fmov	s0, #-1.000000000000000000e+00
 15d353c:	1e2e1001 	fmov	s1, #1.000000000000000000e+00
 15d3540:	1e2e1002 	fmov	s2, #1.000000000000000000e+00
 15d3544:	aa1f03e1 	mov	x1, xzr
 15d3548:	94577736 	bl	2bb1220 <__start_il2cpp@@Base+0x1723304>
 15d354c:	f9401268 	ldr	x8, [x19, #32]
 15d3550:	b40004a8 	cbz	x8, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3554:	b9401909 	ldr	w9, [x8, #24]
 15d3558:	6b14013f 	cmp	w9, w20
 15d355c:	54000469 	b.ls	15d35e8 <__start_il2cpp@@Base+0x1456cc>  // b.plast
 15d3560:	93407e95 	sxtw	x21, w20
 15d3564:	8b150d08 	add	x8, x8, x21, lsl #3
 15d3568:	f9401100 	ldr	x0, [x8, #32]
 15d356c:	b40003c0 	cbz	x0, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3570:	b000d168 	adrp	x8, 3000000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x4738>
 15d3574:	f9475508 	ldr	x8, [x8, #3752]
 15d3578:	f9400101 	ldr	x1, [x8]
 15d357c:	940756c9 	bl	17a90a0 <__start_il2cpp@@Base+0x31b184>
 15d3580:	b4000320 	cbz	x0, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d3584:	d000d168 	adrp	x8, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15d3588:	aa1f03e2 	mov	x2, xzr
 15d358c:	f943d508 	ldr	x8, [x8, #1960]
 15d3590:	f9400101 	ldr	x1, [x8]
 15d3594:	94565345 	bl	2b682a8 <__start_il2cpp@@Base+0x16da38c>
 15d3598:	f9401268 	ldr	x8, [x19, #32]
 15d359c:	b4000248 	cbz	x8, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d35a0:	b9401909 	ldr	w9, [x8, #24]
 15d35a4:	6b14013f 	cmp	w9, w20
 15d35a8:	54000209 	b.ls	15d35e8 <__start_il2cpp@@Base+0x1456cc>  // b.plast
 15d35ac:	8b150d08 	add	x8, x8, x21, lsl #3
 15d35b0:	aa1303e0 	mov	x0, x19
 15d35b4:	aa1f03e1 	mov	x1, xzr
 15d35b8:	f9401114 	ldr	x20, [x8, #32]
 15d35bc:	94573a79 	bl	2ba1fa0 <__start_il2cpp@@Base+0x1714084>
 15d35c0:	b4000120 	cbz	x0, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d35c4:	aa1f03e1 	mov	x1, xzr
 15d35c8:	945774db 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15d35cc:	b40000d4 	cbz	x20, 15d35e4 <__start_il2cpp@@Base+0x1456c8>
 15d35d0:	aa1403e0 	mov	x0, x20
 15d35d4:	a9414ff4 	ldp	x20, x19, [sp, #16]
 15d35d8:	aa1f03e1 	mov	x1, xzr
 15d35dc:	a8c257fe 	ldp	x30, x21, [sp], #32
 15d35e0:	1457750a 	b	2bb0a08 <__start_il2cpp@@Base+0x1722aec>
 15d35e4:	97f728ec 	bl	139d994 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb87c>
 15d35e8:	97f728ed 	bl	139d99c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb884>
 15d35ec:	aa1f03e1 	mov	x1, xzr
 15d35f0:	14575243 	b	2ba7efc <__start_il2cpp@@Base+0x1719fe0>
 15d35f4:	fc1d0fe8 	str	d8, [sp, #-48]!
 15d35f8:	f90007fe 	str	x30, [sp, #8]
 15d35fc:	a90157f6 	stp	x22, x21, [sp, #16]
 15d3600:	a9024ff4 	stp	x20, x19, [sp, #32]
 15d3604:	d000e0f5 	adrp	x21, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15d3608:	aa0103f4 	mov	x20, x1
 15d360c:	aa0003f3 	mov	x19, x0
 15d3610:	396ab2a8 	ldrb	w8, [x21, #2732]
 15d3614:	37000128 	tbnz	w8, #0, 15d3638 <__start_il2cpp@@Base+0x14571c>
 15d3618:	b000d160 	adrp	x0, 3000000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x4738>
 15d361c:	f9454400 	ldr	x0, [x0, #2696]
 15d3620:	97f7284b 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15d3624:	d000d160 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
ASM END

## NinjaMovementScript.ResetDashCoolDown
- RVA: 0x15ce9b0; window: 256 bytes; objdump exit: 0; instruction rows: 64
ASM START

lib/arm64-v8a/libil2cpp.so:     file format elf64-littleaarch64


Disassembly of section il2cpp:

00000000015ce9b0 <__start_il2cpp@@Base+0x140a94>:
 15ce9b0:	b941b008 	ldr	w8, [x0, #432]
 15ce9b4:	11000508 	add	w8, w8, #0x1
 15ce9b8:	b901b008 	str	w8, [x0, #432]
 15ce9bc:	d65f03c0 	ret
 15ce9c0:	6db923e9 	stp	d9, d8, [sp, #-112]!
 15ce9c4:	a9017bfd 	stp	x29, x30, [sp, #16]
 15ce9c8:	a9026ffc 	stp	x28, x27, [sp, #32]
 15ce9cc:	a90367fa 	stp	x26, x25, [sp, #48]
 15ce9d0:	a9045ff8 	stp	x24, x23, [sp, #64]
 15ce9d4:	a90557f6 	stp	x22, x21, [sp, #80]
 15ce9d8:	a9064ff4 	stp	x20, x19, [sp, #96]
 15ce9dc:	f000e114 	adrp	x20, 31f1000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x1f5738>
 15ce9e0:	aa0003f3 	mov	x19, x0
 15ce9e4:	3969da88 	ldrb	w8, [x20, #2678]
 15ce9e8:	37000308 	tbnz	w8, #0, 15cea48 <__start_il2cpp@@Base+0x140b2c>
 15ce9ec:	b000d180 	adrp	x0, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15ce9f0:	f9460400 	ldr	x0, [x0, #3080]
 15ce9f4:	97f73b56 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15ce9f8:	f000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15ce9fc:	f947cc00 	ldr	x0, [x0, #3992]
 15cea00:	97f73b53 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea04:	9000d180 	adrp	x0, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
 15cea08:	f946c400 	ldr	x0, [x0, #3464]
 15cea0c:	97f73b50 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea10:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cea14:	f9401400 	ldr	x0, [x0, #40]
 15cea18:	97f73b4d 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea1c:	9000d1a0 	adrp	x0, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15cea20:	f9400000 	ldr	x0, [x0]
 15cea24:	97f73b4a 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea28:	d000d180 	adrp	x0, 3000000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x4738>
 15cea2c:	f946a400 	ldr	x0, [x0, #3400]
 15cea30:	97f73b47 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea34:	f000d180 	adrp	x0, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15cea38:	f943a000 	ldr	x0, [x0, #1856]
 15cea3c:	97f73b44 	bl	139d74c <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb634>
 15cea40:	52800028 	mov	w8, #0x1                   	// #1
 15cea44:	3929da88 	strb	w8, [x20, #2678]
 15cea48:	f9404a60 	ldr	x0, [x19, #144]
 15cea4c:	b4000d40 	cbz	x0, 15cebf4 <__start_il2cpp@@Base+0x140cd8>
 15cea50:	b000d194 	adrp	x20, 2fff000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x3738>
 15cea54:	aa1f03e1 	mov	x1, xzr
 15cea58:	f9460694 	ldr	x20, [x20, #3080]
 15cea5c:	945787b6 	bl	2bb0934 <__start_il2cpp@@Base+0x1722a18>
 15cea60:	1e204008 	fmov	s8, s0
 15cea64:	f9400280 	ldr	x0, [x20]
 15cea68:	1e204029 	fmov	s9, s1
 15cea6c:	b940e408 	ldr	w8, [x0, #228]
 15cea70:	35000048 	cbnz	w8, 15cea78 <__start_il2cpp@@Base+0x140b5c>
 15cea74:	97f73b7d 	bl	139d868 <_ZTSN10__cxxabiv121__vmi_class_type_infoE@@Base+0x8bb750>
 15cea78:	1e204100 	fmov	s0, s8
 15cea7c:	1e204121 	fmov	s1, s9
 15cea80:	90ff8fe8 	adrp	x8, 7ca000 <_ZTSNSt6__ndk117bad_function_callE@@Base-0x312091>
 15cea84:	bd46dd02 	ldr	s2, [x8, #1756]
 15cea88:	aa1f03e0 	mov	x0, xzr
 15cea8c:	9458adc1 	bl	2bfa190 <__start_il2cpp@@Base+0x176c274>
 15cea90:	b4000b20 	cbz	x0, 15cebf4 <__start_il2cpp@@Base+0x140cd8>
 15cea94:	b9401808 	ldr	w8, [x0, #24]
 15cea98:	aa0003f4 	mov	x20, x0
 15cea9c:	7100051f 	cmp	w8, #0x1
 15ceaa0:	5400096b 	b.lt	15cebcc <__start_il2cpp@@Base+0x140cb0>  // b.tstop
 15ceaa4:	f000d197 	adrp	x23, 3001000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x5738>
 15ceaa8:	9000d1b8 	adrp	x24, 3002000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x6738>
 15ceaac:	9000d199 	adrp	x25, 2ffe000 <_ZTVN10__cxxabiv129__pointer_to_member_type_infoE@@Base+0x2738>
ASM END

## Interpretation boundary
- This can identify the native methods and helper calls associated with existing Dash, transformation/concealment, projectile and movement routines.
- New gameplay behavior is not implemented by inspecting disassembly alone. Any future native patch must be architecture-correct and validated with package integrity plus actual Android runtime testing.
- Existing maps, scene layouts, transforms and colliders remain untouched.
