S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 4400
Date: 2018-09-09 11:46:48+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2

Register Information
r0   = 0x00000002, r1   = 0x00000025
r2   = 0xbe80714c, r3   = 0x00000002
r4   = 0xfbad8001, r5   = 0xbe807030
r6   = 0xbe80714c, r7   = 0x4040b000
r8   = 0x00000000, r9   = 0x00001130
r10  = 0x00000002, fp   = 0xbe807024
ip   = 0x4040a9c8, sp   = 0xbe806aa8
lr   = 0x4031af50, pc   = 0x40357928
cpsr = 0x20000010

Memory Information
MemTotal:   490112 KB
MemFree:     10132 KB
Buffers:     26452 KB
Cached:     162020 KB
VmPeak:      82480 KB
VmSize:      82412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15976 KB
VmRSS:       15976 KB
VmData:      21848 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       24612 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4400 TID = 4400
4400 4406 4407 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
40004000 40008000 r-xp /usr/lib/libsys-assert.so
40012000 4002f000 r-xp /lib/ld-2.13.so
40039000 40044000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 40062000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40063000 40065000 r-xp /usr/lib/libdlog.so.0.0.0
4006d000 4008e000 r-xp /usr/lib/libefl-extension.so.0.1.0
40096000 401d2000 r-xp /usr/lib/libelementary.so.1.7.99
401e9000 402b7000 r-xp /usr/lib/libevas.so.1.7.99
402dd000 40401000 r-xp /lib/libc-2.13.so
4040f000 40417000 r-xp /lib/libgcc_s-4.6.so.1
40418000 40423000 r-xp /lib/libunwind.so.8.0.1
40450000 40452000 r-xp /lib/libdl-2.13.so
4045b000 4045f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40468000 4046a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40473000 40479000 r-xp /usr/lib/libappcore-efl.so.1.1
40481000 40486000 r-xp /usr/lib/libappcore-common.so.1.1
4048e000 4049b000 r-xp /usr/lib/libaul.so.0.1.0
404a5000 404c8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404d0000 40511000 r-xp /usr/lib/libeina.so.1.7.99
4051a000 4052e000 r-xp /lib/libpthread-2.13.so
40539000 40589000 r-xp /usr/lib/libecore_x.so.1.7.99
4058b000 405ad000 r-xp /usr/lib/libecore_evas.so.1.7.99
405b6000 405bf000 r-xp /usr/lib/libvconf.so.0.2.45
405c7000 405ef000 r-xp /usr/lib/libfontconfig.so.1.8.0
405f0000 406bc000 r-xp /usr/lib/libxml2.so.2.7.8
406c9000 40799000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4079a000 407ac000 r-xp /usr/lib/libefl-assist.so.0.1.0
407b4000 4081d000 r-xp /lib/libm-2.13.so
40826000 4083d000 r-xp /usr/lib/libecore.so.1.7.99
40854000 408b2000 r-xp /usr/lib/libedje.so.1.7.99
408bc000 40974000 r-xp /usr/lib/libcairo.so.2.11200.14
4097f000 40a60000 r-xp /usr/lib/libX11.so.6.3.0
40a6b000 40a74000 r-xp /usr/lib/libXi.so.6.1.0
40a7c000 40a95000 r-xp /usr/lib/libeet.so.1.7.99
40aa6000 40aab000 r-xp /usr/lib/libecore_file.so.1.7.99
40ab3000 40ac4000 r-xp /usr/lib/libecore_input.so.1.7.99
40acc000 40ad5000 r-xp /usr/lib/libedbus.so.1.7.99
40add000 40b07000 r-xp /usr/lib/libdbus-1.so.3.8.12
40b10000 40b2a000 r-xp /usr/lib/libecore_con.so.1.7.99
40b33000 40b46000 r-xp /usr/lib/libfribidi.so.0.3.1
40b4e000 40b93000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40b9c000 40bf2000 r-xp /usr/lib/libfreetype.so.6.11.3
40bfe000 40c54000 r-xp /usr/lib/libpixman-1.so.0.28.2
40c61000 40c67000 r-xp /usr/lib/libappsvc.so.0.1.0
40c6f000 40c72000 r-xp /usr/lib/libbundle.so.0.1.22
40c7a000 40c80000 r-xp /usr/lib/libecore_imf.so.1.7.99
40c88000 40cbc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40cc5000 40cc7000 r-xp /usr/lib/libiniparser.so.0
40cd0000 40ce7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40cf0000 40cf5000 r-xp /usr/lib/libxdgmime.so.1.1.0
40cfd000 40cfe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40d06000 40d24000 r-xp /usr/lib/libsystemd.so.0.4.0
40d2e000 40d48000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40d50000 40dc5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40dd0000 40dd6000 r-xp /lib/librt-2.13.so
40ddf000 40de6000 r-xp /usr/lib/libXcursor.so.1.0.2
40dee000 40df0000 r-xp /usr/lib/libXdamage.so.1.1.0
40df8000 40dfa000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e02000 40e04000 r-xp /usr/lib/libXgesture.so.7.0.0
40e0d000 40e10000 r-xp /usr/lib/libXfixes.so.3.1.0
40e18000 40e19000 r-xp /usr/lib/libXinerama.so.1.0.0
40e22000 40e28000 r-xp /usr/lib/libXrandr.so.2.2.0
40e30000 40e36000 r-xp /usr/lib/libXrender.so.1.3.0
40e3e000 40e42000 r-xp /usr/lib/libXtst.so.6.1.0
40e4a000 40e54000 r-xp /usr/lib/libXext.so.6.4.0
40e5e000 40e63000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e6c000 40e70000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e79000 40e7c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e84000 40e9a000 r-xp /lib/libexpat.so.1.6.0
40ea4000 40eba000 r-xp /lib/libz.so.1.2.5
40ec3000 40ed9000 r-xp /usr/lib/libtts.so
40ee2000 40f05000 r-xp /usr/lib/libui-extension.so.0.1.0
40f0e000 40f19000 r-xp /usr/lib/libtbm.so.1.0.0
40f21000 40f28000 r-xp /usr/lib/libembryo.so.1.7.99
40f30000 40f47000 r-xp /usr/lib/liblua-5.1.so
40f51000 40f52000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40f5a000 40f68000 r-xp /usr/lib/libGLESv2.so.2.0
40f71000 40f89000 r-xp /usr/lib/libpng12.so.0.50.0
40f91000 40f92000 r-xp /usr/lib/libxcb-shm.so.0.0.0
40f9b000 40fa1000 r-xp /usr/lib/libxcb-render.so.0.0.0
40faa000 40fbd000 r-xp /usr/lib/libxcb.so.1.1.0
40fc6000 40fc9000 r-xp /usr/lib/libEGL.so.1.4
40fd1000 40ff4000 r-xp /usr/lib/libjpeg.so.8.0.2
4100c000 41050000 r-xp /usr/lib/libcurl.so.4.3.0
4105a000 41060000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
41069000 4106a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41072000 41077000 r-xp /usr/lib/libffi.so.5.0.10
4107f000 41152000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
4115d000 4115f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
41168000 41180000 r-xp /usr/lib/liblzma.so.5.0.3
41188000 41198000 r-xp /lib/libresolv-2.13.so
4119c000 4119e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
411a7000 411a9000 r-xp /usr/lib/journal/libjournal.so.0.1.0
411b2000 411b7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
411bf000 411ee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
411f6000 411f9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41201000 41202000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4120b000 41393000 r-xp /usr/lib/libicui18n.so.57.1
413a4000 414aa000 r-xp /usr/lib/libicuuc.so.57.1
414c0000 41554000 r-xp /usr/lib/libstdc++.so.6.0.16
41567000 4156f000 r-xp /usr/lib/libdrm.so.2.4.0
41577000 41579000 r-xp /usr/lib/libdri2.so.0.0.0
41581000 41583000 r-xp /usr/lib/libXau.so.6.0.0
4158c000 41595000 r-xp /usr/lib/libcares.so.2.1.0
4159e000 415cc000 r-xp /usr/lib/libidn.so.11.5.44
415d4000 4161b000 r-xp /usr/lib/libssl.so.1.0.0
41627000 417b9000 r-xp /usr/lib/libcrypto.so.1.0.0
417da000 417dc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
417e5000 417e9000 r-xp /usr/lib/libsmack.so.1.0.0
417f2000 4180f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
41818000 4181e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41826000 4182b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41833000 4184c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
430ee000 430f0000 r-xp /usr/lib/libiri.so
430f8000 430fb000 r-xp /lib/libcap.so.2.21
43103000 4310a000 r-xp /lib/libcrypt-2.13.so
4313a000 4315b000 r-xp /usr/lib/libexif.so.12.3.3
4316f000 43171000 r-xp /usr/lib/libttrace.so.1.1
43179000 4317e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43186000 4318c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43195000 4319d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
431a5000 431a8000 r-xp /lib/libattr.so.1.1.0
431b1000 431d3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431dc000 431e3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431ec000 431ee000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431f6000 431fd000 r-xp /usr/lib/libminizip.so.1.0.0
43205000 43212000 r-xp /usr/lib/libail.so.0.1.0
4321c000 43222000 r-xp /usr/lib/libproc-stat.so.0.2.96
4322a000 4322b000 r-xp /usr/lib/libresponse.so.0.2.96
43233000 43238000 r-xp /usr/lib/libsystem.so.0.0.0
43348000 43412000 r-xp /usr/lib/libCOREGL.so.4.0
43424000 43448000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
43451000 43520000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43536000 43540000 r-xp /lib/libnss_files-2.13.so
43868000 438dd000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
438ed000 43a36000 r-xp /usr/lib/egl/libMali.so
43a43000 43a48000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43a59000 43a5c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43a65000 44264000 rw-p [stack:4406]
44265000 44a64000 rw-p [stack:4407]
44d18000 44d2f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44edf000 44ee0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
be7e7000 be808000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4400)
Call Stack Count: 1
 0: strchrnul + 0x14 (0x40357928) [/lib/libc.so.6] + 0x7a928
End of Call Stack

Package Information
Package Name: co.za.littlekidogo.watchapp
Package ID : co.za.littlekidogo.watchapp
Version: 1.0.0
Package Type: rpm
App Name: watchapp
App ID: co.za.littlekidogo.watchapp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ect_event_activated_set(291) > Activation delete!!!!
09-09 11:46:45.010+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 11:46:45.010+0200 W/W_HOME  ( 1088): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-09 11:46:45.050+0200 W/W_HOME  ( 1088): gesture.c: _widget_updated_cb(188) > widget updated
09-09 11:46:45.050+0200 W/W_HOME  ( 1088): gesture.c: _manual_render_disable_timer_del(157) > timer del
09-09 11:46:45.050+0200 W/W_HOME  ( 1088): gesture.c: _manual_render(182) > 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : none
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : 
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string :  
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(144) > [windicator_ongoing_info_shealth_update:144] [Update] SHealth status is none, so hide icon and text!
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[1]
09-09 11:46:45.155+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
09-09 11:46:45.155+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
09-09 11:46:45.155+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 11:46:45.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.155+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
09-09 11:46:45.155+0200 W/W_INDICATOR( 1003): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[2]
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.160+0200 W/W_INDICATOR( 1003): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 80
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 11:46:45.160+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
09-09 11:46:45.165+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 11:46:45.165+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 11:46:45.165+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 11:46:45.170+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 11:46:45.170+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 11:46:45.175+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [964].
09-09 11:46:45.175+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1746865882)
09-09 11:46:45.185+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 11:46:45.185+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 11:46:45.185+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 09:59:59 (UTC).
09-09 11:46:45.185+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 11:46:45.185+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:46:45.195+0200 W/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
09-09 11:46:45.195+0200 E/WAKEUP-SERVICE( 1291): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
09-09 11:46:45.195+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 11:46:45.195+0200 E/ALARM_MANAGER(  524): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1746865882] is removed.
09-09 11:46:45.195+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 11:46:45.200+0200 W/STARTER (  964): clock-mgr.c: _on_lcd_signal_receive_cb(1271) > [_on_lcd_signal_receive_cb:1271] _on_lcd_signal_receive_cb, 1271, Post LCD on by [unknown]
09-09 11:46:45.200+0200 W/STARTER (  964): clock-mgr.c: _post_lcd_on(1059) > [_post_lcd_on:1059] LCD ON as reserved app[(null)] alpm mode[0]
09-09 11:46:45.215+0200 W/W_HOME  ( 1088): gesture.c: _manual_render(182) > 
09-09 11:46:45.225+0200 W/W_HOME  ( 1088): gesture.c: _manual_render_enable(138) > 0
09-09 11:46:45.230+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
09-09 11:46:45.230+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 0, connected : 0
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.230+0200 W/STARTER (  964): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:45.230+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:45.235+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:45.235+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [0]
09-09 11:46:45.235+0200 W/SHealthCommon( 1374): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
09-09 11:46:45.235+0200 E/WAKEUP-SERVICE( 1291): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
09-09 11:46:45.235+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
09-09 11:46:45.235+0200 W/SHealthServiceCommon( 1374): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
09-09 11:46:45.260+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
09-09 11:46:45.270+0200 W/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-09 11:46:45.275+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
09-09 11:46:45.275+0200 I/HIGEAR  ( 1291): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
09-09 11:46:45.275+0200 W/SHealthServiceCommon( 1374): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1536444000000.000000, end 1536486405279.000000, calories 805.792318[0;m
09-09 11:46:45.275+0200 W/SHealthCommon( 1374): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
09-09 11:46:45.960+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2520468 button=1
09-09 11:46:45.960+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:45.960+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:45.960+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [56, 225]
09-09 11:46:45.960+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 11:46:45.960+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:45.980+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:45.980+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:45.990+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:46.005+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:46.010+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:46.010+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.015+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 11:46:46.015+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:46.015+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:46.015+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.015+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-service.c: _music_control_service_pasre_request(565) > [33m[TID:1500]   [com.samsung.w-home]register msg port [true][0m
09-09 11:46:46.015+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:46:46.025+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2520538 button=1
09-09 11:46:46.025+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [56, 225]->[63, 207]
09-09 11:46:46.025+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[14], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[15]
09-09 11:46:46.025+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 11:46:46.025+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 11:46:46.025+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 11:46:46.025+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:46:46.025+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1088
09-09 11:46:46.025+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:46:46.030+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 11:46:46.030+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 11:46:46.040+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 11:46:46.045+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 11:46:46.045+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 11:46:46.045+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 11:46:46.045+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.045+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.050+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:46:46.050+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 11:46:46.050+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:46:46.050+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:46:46.050+0200 W/AUL_PAD ( 4316): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 11:46:46.050+0200 W/AUL_PAD ( 4316): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 11:46:46.050+0200 W/AUL_PAD ( 4316): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 11:46:46.050+0200 W/AUL_PAD ( 4316): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:46.050+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.055+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 11:46:46.055+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 11:46:46.055+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 11:46:46.055+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 11:46:46.055+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:46.055+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.060+0200 I/TIZEN_N_SOUND_MANAGER( 1500): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000225
09-09 11:46:46.060+0200 E/TIZEN_N_SOUND_MANAGER( 1500): sound_manager_private.c: __convert_sound_manager_error_code(158) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000225)
09-09 11:46:46.060+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-sound-manager.c: music_control_sound_mgr_get_volume(109) > [31m[TID:1500]   sound_manager_get_volume() .. [0xfe6a0001][0m
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 11:46:46.060+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.095+0200 I/efl-extension( 4316): efl_extension.c: eext_mod_init(40) > Init
09-09 11:46:46.100+0200 I/UXT     ( 4316): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:46:46.100+0200 W/AUL_PAD ( 4316): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 11:46:46.100+0200 W/AUL_PAD ( 4316): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 11:46:46.100+0200 I/CAPI_APPFW_APPLICATION( 4316): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:46:46.105+0200 I/CAPI_APPFW_APPLICATION( 4316): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:46:46.150+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(4316) type(uiapp) bg(0)
09-09 11:46:46.150+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (4316) was created
09-09 11:46:46.150+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 11:46:46.150+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4316)
09-09 11:46:46.150+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 11:46:46.155+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 11:46:46.155+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 11:46:46.155+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:46.155+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4316]
09-09 11:46:46.160+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 11:46:46.160+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 11:46:46.160+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 11:46:46.165+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 11:46:46.175+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 11:46:46.175+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 11:46:46.175+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 11:46:46.215+0200 E/EFL     ( 4316): ecore_evas<4316> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:46:46.340+0200 W/CRASH_MANAGER( 4229): worker.c: worker_job(1205) > 11043167761741536486406
09-09 11:46:47.030+0200 E/EFL     (  404): ecore_x<404> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600003 time=2520732
09-09 11:46:47.030+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=2520732
09-09 11:46:47.030+0200 E/EFL     (  404): ecore_x<404> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=2520732
09-09 11:46:47.190+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4316 pgid = 4316
09-09 11:46:47.190+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-09 11:46:47.195+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:46:47.200+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:46:47.200+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(4316), proc(0)
09-09 11:46:47.200+0200 E/AUL     ( 1272): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:46:47.200+0200 E/CAPI_APPFW_APP_MANAGER( 1272): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:46:47.200+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:46:47.235+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __read_proc(55) > file open error : 2
09-09 11:46:47.235+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
09-09 11:46:47.235+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(4316), proc(0)
09-09 11:46:47.235+0200 E/SECURITY_EXTENSION_SERVER(  508): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
09-09 11:46:47.235+0200 E/AUL     ( 1374): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
09-09 11:46:47.235+0200 E/CAPI_APPFW_APP_MANAGER( 1374): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
09-09 11:46:47.245+0200 W/AUL_PAD ( 1235): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-09 11:46:47.250+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4316
09-09 11:46:47.250+0200 W/AUL     (  509): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4316)
09-09 11:46:47.395+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2521910 button=1
09-09 11:46:47.395+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:47.395+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:47.395+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [140, 156]
09-09 11:46:47.395+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 11:46:47.395+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:46:47.395+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:46:47.395+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 11:46:47.395+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 11:46:47.435+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:47.450+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 11:46:47.460+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2521975 button=1
09-09 11:46:47.460+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [140, 156]->[139, 165]
09-09 11:46:47.460+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 11:46:47.460+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 11:46:47.460+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 11:46:47.460+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 11:46:47.460+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 11:46:47.465+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 11:46:47.465+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 11:46:47.465+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 11:46:47.480+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 2
09-09 11:46:47.485+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 11:46:47.485+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
09-09 11:46:47.485+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 11:46:47.485+0200 E/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(278) > launching failed
09-09 11:46:47.485+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
09-09 11:46:47.485+0200 W/AUL_AMD (  509): amd_launch.c: start_process(606) > child process: 4400
09-09 11:46:47.540+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 4400
09-09 11:46:47.540+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(4400) type(uiapp) bg(0)
09-09 11:46:47.540+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 11:46:47.540+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [4400]
09-09 11:46:47.540+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4400)
09-09 11:46:47.540+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 11:46:47.550+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 11:46:47.550+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 11:46:47.550+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 11:46:47.550+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 11:46:47.550+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 11:46:47.550+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 11:46:47.585+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:46:47.590+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4400
09-09 11:46:47.595+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:46:47.675+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 11:46:47.675+0200 I/efl-extension( 4400): efl_extension.c: eext_mod_init(40) > Init
09-09 11:46:47.685+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4400
09-09 11:46:47.695+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 12
09-09 11:46:47.695+0200 I/CAPI_APPFW_APPLICATION( 4400): app_main.c: ui_app_main(704) > app_efl_main
09-09 11:46:47.740+0200 I/UXT     ( 4400): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 11:46:47.755+0200 I/AUL_PAD ( 4394): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-09 11:46:47.900+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (4400) was created
09-09 11:46:47.905+0200 I/CAPI_APPFW_APPLICATION( 4400): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 11:46:47.955+0200 E/MALI    ( 4400): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
09-09 11:46:47.955+0200 E/MALI    ( 4400): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
09-09 11:46:47.955+0200 E/MALI    ( 4400): [gpu-ddk] devel/graphics_drv/r4p0
09-09 11:46:47.955+0200 E/MALI    ( 4400): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
09-09 11:46:47.955+0200 E/MALI    ( 4400): [coregl] devel/graphics_engine/master
09-09 11:46:47.955+0200 E/MALI    ( 4400): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
09-09 11:46:48.105+0200 E/EFL     ( 4400): ecore_evas<4400> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 11:46:48.250+0200 W/CRASH_MANAGER( 4229): worker.c: worker_job(1205) > 1104400776174153648640
