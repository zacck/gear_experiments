S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: watchapp
PID: 9550
Date: 2018-09-09 12:30:04+0200
Executable File Path: /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000004, r1   = 0x00000004
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xbefcadd8
r6   = 0x413c0695, r7   = 0x00000004
r8   = 0x00000029, r9   = 0x00000000
r10  = 0x413c0680, fp   = 0xbefcadcc
ip   = 0xbefcb31c, sp   = 0xbefca860
lr   = 0x404bee8c, pc   = 0x404f40b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:      9952 KB
Buffers:     31800 KB
Cached:     148544 KB
VmPeak:      63220 KB
VmSize:      63216 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13712 KB
VmRSS:       13712 KB
VmData:       4432 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22892 KB
VmPTE:          42 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 4030a000 r-xp /usr/lib/libecore.so.1.7.99
40321000 4037f000 r-xp /usr/lib/libedje.so.1.7.99
40389000 40459000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4045a000 40460000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40468000 4046c000 r-xp /usr/lib/libsmack.so.1.0.0
40475000 4047d000 r-xp /lib/libgcc_s-4.6.so.1
4047e000 405a2000 r-xp /lib/libc-2.13.so
405b0000 405ce000 r-xp /usr/lib/libsystemd.so.0.4.0
405d8000 405e3000 r-xp /lib/libunwind.so.8.0.1
40610000 40627000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062f000 40659000 r-xp /usr/lib/libdbus-1.so.3.8.12
40662000 40667000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066f000 40692000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4069a000 4069b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a3000 406a9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b2000 4071b000 r-xp /lib/libm-2.13.so
40724000 4073d000 r-xp /usr/lib/libeet.so.1.7.99
4074e000 4078f000 r-xp /usr/lib/libeina.so.1.7.99
40798000 407ba000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c3000 407c8000 r-xp /usr/lib/libecore_file.so.1.7.99
407d0000 407e1000 r-xp /usr/lib/libecore_input.so.1.7.99
407e9000 407f2000 r-xp /usr/lib/libvconf.so.0.2.45
407fa000 4084a000 r-xp /usr/lib/libecore_x.so.1.7.99
4084c000 40855000 r-xp /usr/lib/libedbus.so.1.7.99
4085d000 40877000 r-xp /usr/lib/libecore_con.so.1.7.99
40880000 40893000 r-xp /usr/lib/libfribidi.so.0.3.1
4089b000 408e0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e9000 40911000 r-xp /usr/lib/libfontconfig.so.1.8.0
40912000 40968000 r-xp /usr/lib/libfreetype.so.6.11.3
40974000 409ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d7000 409dd000 r-xp /lib/librt-2.13.so
409e6000 409ed000 r-xp /usr/lib/libembryo.so.1.7.99
409f5000 40a0c000 r-xp /usr/lib/liblua-5.1.so
40a15000 40a1b000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a23000 40a24000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2c000 40a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a63000 40a66000 r-xp /lib/libcap.so.2.21
40a6e000 40a86000 r-xp /usr/lib/liblzma.so.5.0.3
40a8e000 40a9e000 r-xp /lib/libresolv-2.13.so
40aa2000 40b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b80000 40bb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbd000 40bd7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bdf000 40c54000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5e000 40c60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c68000 40c7e000 r-xp /lib/libz.so.1.2.5
40c86000 40ca9000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc1000 40da2000 r-xp /usr/lib/libX11.so.6.3.0
40dad000 40db2000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dbb000 40dbf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc8000 40dcb000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd3000 40dda000 r-xp /usr/lib/libXcursor.so.1.0.2
40de2000 40de4000 r-xp /usr/lib/libXdamage.so.1.1.0
40dec000 40dee000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df6000 40df8000 r-xp /usr/lib/libXgesture.so.7.0.0
40e00000 40e03000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0b000 40e14000 r-xp /usr/lib/libXi.so.6.1.0
40e1c000 40e1d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e26000 40e2c000 r-xp /usr/lib/libXrandr.so.2.2.0
40e34000 40e3a000 r-xp /usr/lib/libXrender.so.1.3.0
40e42000 40e46000 r-xp /usr/lib/libXtst.so.6.1.0
40e4e000 40e58000 r-xp /usr/lib/libXext.so.6.4.0
40e61000 40ea5000 r-xp /usr/lib/libcurl.so.4.3.0
40eae000 40ec4000 r-xp /lib/libexpat.so.1.6.0
40ece000 40ee6000 r-xp /usr/lib/libpng12.so.0.50.0
40eee000 40f0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f14000 40fa8000 r-xp /usr/lib/libstdc++.so.6.0.16
40fbb000 40fbe000 r-xp /lib/libattr.so.1.1.0
40fc6000 40fc7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fcf000 40fd4000 r-xp /usr/lib/libffi.so.5.0.10
40fdd000 40fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe7000 410b3000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410cb000 410cd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d5000 410e8000 r-xp /usr/lib/libxcb.so.1.1.0
410f2000 410fb000 r-xp /usr/lib/libcares.so.2.1.0
41104000 41132000 r-xp /usr/lib/libidn.so.11.5.44
4113a000 41181000 r-xp /usr/lib/libssl.so.1.0.0
4118d000 4131f000 r-xp /usr/lib/libcrypto.so.1.0.0
41341000 41343000 r-xp /usr/lib/libiri.so
4134b000 41352000 r-xp /lib/libcrypt-2.13.so
41382000 41384000 r-xp /usr/lib/libXau.so.6.0.0
41391000 41395000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139d000 413a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a7000 413ac000 r-xp /usr/lib/libappcore-common.so.1.1
413b4000 413b6000 r-xp /usr/lib/libiniparser.so.0
413bf000 413c1000 r-xp /opt/usr/apps/co.za.littlekidogo.watchapp/bin/watchapp
413d5000 413d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e2000 413e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ed000 413f3000 r-xp /usr/lib/libappsvc.so.0.1.0
413fb000 4141f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41428000 414f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150d000 41517000 r-xp /lib/libnss_files-2.13.so
416b4000 416bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416ca000 416eb000 r-xp /usr/lib/libefl-extension.so.0.1.0
416f3000 41705000 r-xp /usr/lib/libefl-assist.so.0.1.0
4170d000 417c5000 r-xp /usr/lib/libcairo.so.2.11200.14
417d0000 417e6000 r-xp /usr/lib/libtts.so
417ef000 41812000 r-xp /usr/lib/libui-extension.so.0.1.0
4181b000 41826000 r-xp /usr/lib/libtbm.so.1.0.0
4182e000 4183c000 r-xp /usr/lib/libGLESv2.so.2.0
41845000 41846000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4184f000 41855000 r-xp /usr/lib/libxcb-render.so.0.0.0
4185d000 41860000 r-xp /usr/lib/libEGL.so.1.4
41868000 4186d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41875000 41878000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41880000 41881000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4188a000 41990000 r-xp /usr/lib/libicuuc.so.57.1
419ad000 41ada000 rw-p [heap]
41ada000 41c62000 r-xp /usr/lib/libicui18n.so.57.1
41c72000 41c7a000 r-xp /usr/lib/libdrm.so.2.4.0
41c82000 41c84000 r-xp /usr/lib/libdri2.so.0.0.0
41c8c000 41c92000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c9a000 41c9f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ca7000 41cc0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43561000 43582000 r-xp /usr/lib/libexif.so.12.3.3
43595000 43597000 r-xp /usr/lib/libttrace.so.1.1
4359f000 435a4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
435ac000 435b2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
435bb000 435c3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
435cb000 435ed000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
435f6000 435fd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43606000 43608000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43610000 43617000 r-xp /usr/lib/libminizip.so.1.0.0
4361f000 4362c000 r-xp /usr/lib/libail.so.0.1.0
43635000 4363b000 r-xp /usr/lib/libproc-stat.so.0.2.96
43643000 43644000 r-xp /usr/lib/libresponse.so.0.2.96
4364c000 43651000 r-xp /usr/lib/libsystem.so.0.0.0
4365b000 43725000 r-xp /usr/lib/libCOREGL.so.4.0
43a56000 43a61000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43a6a000 43a6f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43a77000 43a8e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c34000 43c35000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
befab000 befcc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9550)
Call Stack Count: 1
 0: strlen + 0x4 (0x404f40b4) [/lib/libc.so.6] + 0x760b4
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
part-resource-evas.cpp: UpdateLayout(1868) > colon 14x110 at (122,9)
09-09 12:30:00.915+0200 E/EFL     ( 1151): elementary<1151> elm_layout.c:2216 elm_layout_add() could not add 0x48daf6c0 as sub object of 0x44ad2620
09-09 12:30:00.920+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.509187)
09-09 12:30:00.920+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(903), py(0)
09-09 12:30:00.920+0200 W/W_HOME  ( 1088): index.c: index_show(300) > is_paused:0 show VI:1 visibility:0 vi:(nil)
09-09 12:30:00.925+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.657766)
09-09 12:30:00.925+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.925+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.930+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(956), py(0)
09-09 12:30:00.935+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.657766)
09-09 12:30:00.935+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(956), py(0)
09-09 12:30:00.935+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : inactive time
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: com.samsung.shealth.alert
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : http://tizen.org/appcontrol/operation/alert_noti
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : serialized_data
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : { "is_from_moment_bar" : true, "message_name" : "inactive_before_10min_precaution" }
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : /usr/apps/com.samsung.shealth_gear/shared/res/images//momentbar/moment_bar_indicator_inactive_time.png
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : /usr/apps/com.samsung.shealth_gear/shared/res/images//momentbar/moment_bar_indicator_inactive_time.png
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string : Inactive
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(151) > [windicator_ongoing_info_shealth_update:151] [Update] SHealth status is not none, so show icon and text.
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info.c: windicator_ongoing_info_insert(96) > [windicator_ongoing_info_insert:96] Ongoing info type[1] icon[/usr/apps/com.samsung.shealth_gear/shared/res/images//momentbar/moment_bar_indicator_inactive_time.png] text[Inactive]
09-09 12:30:00.940+0200 W/W_INDICATOR( 1003): windicator_ongoing_info.c: windicator_ongoing_info_insert(137) > [windicator_ongoing_info_insert:137] Icon path : /usr/apps/com.samsung.shealth_gear/shared/res/images//momentbar/moment_bar_indicator_inactive_time.png
09-09 12:30:00.940+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.748882)
09-09 12:30:00.945+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.950+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-09 12:30:00.950+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-09 12:30:00.950+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-9-2018, 10:35:07 (UTC).
09-09 12:30:00.950+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-09 12:30:00.950+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:30:00.955+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.955+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(989), py(0)
09-09 12:30:00.960+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.748882)
09-09 12:30:00.960+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(989), py(0)
09-09 12:30:00.960+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.806723)
09-09 12:30:00.960+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.965+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.965+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1010), py(0)
09-09 12:30:00.970+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-09 12:30:00.970+0200 E/ALARM_MANAGER(  524): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[705779449] is removed.
09-09 12:30:00.970+0200 E/ALARM_MANAGER(  524): alarm-manager.c: __save_module_log(1780) > The file is not ready.
09-09 12:30:00.970+0200 W/W_INDICATOR( 1003): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 80
09-09 12:30:00.970+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.806723)
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:30:00.970+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:00.970+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1010), py(0)
09-09 12:30:00.975+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.853846)
09-09 12:30:00.975+0200 W/STARTER (  964): clock-mgr.c: _on_lcd_signal_receive_cb(1271) > [_on_lcd_signal_receive_cb:1271] _on_lcd_signal_receive_cb, 1271, Post LCD on by [unknown]
09-09 12:30:00.975+0200 W/STARTER (  964): clock-mgr.c: _post_lcd_on(1059) > [_post_lcd_on:1059] LCD ON as reserved app[(null)] alpm mode[0]
09-09 12:30:00.975+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.975+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.975+0200 W/W_INDICATOR( 1003): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
09-09 12:30:00.980+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1027), py(0)
09-09 12:30:00.980+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.853846)
09-09 12:30:00.980+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1027), py(0)
09-09 12:30:00.980+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.873092)
09-09 12:30:00.980+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.980+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
09-09 12:30:00.985+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 12:30:00.985+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
09-09 12:30:00.985+0200 W/W_INDICATOR( 1003): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
09-09 12:30:00.985+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1034), py(0)
09-09 12:30:00.985+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.873092)
09-09 12:30:00.985+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1034), py(0)
09-09 12:30:00.990+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.889042)
09-09 12:30:00.990+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.990+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.990+0200 E/EFL     ( 1151): edje<1151> edje_util.c:3785 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-09 12:30:00.990+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1040), py(0)
09-09 12:30:00.990+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.889042)
09-09 12:30:00.995+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1040), py(0)
09-09 12:30:00.995+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.904873)
09-09 12:30:00.995+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:00.995+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:00.995+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1045), py(0)
09-09 12:30:00.995+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.904873)
09-09 12:30:00.995+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_RENEW : px(1045), py(0)
09-09 12:30:00.995+0200 W/W_HOME  ( 1088): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
09-09 12:30:00.995+0200 W/W_HOME  ( 1088): gesture.c: _manual_render_enable(138) > 0
09-09 12:30:00.995+0200 W/W_HOME  ( 1088): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
09-09 12:30:01.000+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:30:01.005+0200 I/watchface-viewer( 1151): viewer-part-resource-evas.cpp: UpdateLayout(1868) > colon 14x110 at (130,9)
09-09 12:30:01.010+0200 I/watchface-viewer( 1151): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(792) > ImagesLoadingDoneSignal().Emit()
09-09 12:30:01.020+0200 I/efl-extension( 1242): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:30:01.070+0200 I/efl-extension( 1003): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:30:01.070+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
09-09 12:30:01.070+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 0, connected : 0
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
09-09 12:30:01.070+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.075+0200 W/STARTER (  964): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.075+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.080+0200 W/W_INDICATOR( 1003): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [0]
09-09 12:30:01.100+0200 W/SHealthServiceCommon( 1374): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1536444000000.000000, end 1536489001103.000000, calories 854.208439[0;m
09-09 12:30:01.100+0200 W/SHealthCommon( 1374): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
09-09 12:30:01.130+0200 I/efl-extension( 1088): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
09-09 12:30:01.130+0200 I/efl-extension( 1088): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x47c25398, elm_layout, time_stamp : 5115534
09-09 12:30:01.130+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
09-09 12:30:01.130+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[14], ItemListSize[15], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
09-09 12:30:01.140+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
09-09 12:30:01.140+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] time(0.961284)
09-09 12:30:01.140+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3321) > tobj_item_01 is null
09-09 12:30:01.145+0200 I/ELM_RPANEL( 1088): elm-rpanel.c: _panel_swap_effect(3376) > tobj_item_02 is null
09-09 12:30:01.145+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
09-09 12:30:01.145+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] time(0.961284)
09-09 12:30:01.145+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] animation stop!!
09-09 12:30:01.150+0200 W/wnotib  ( 1088): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [1080][0][360][360]
09-09 12:30:01.150+0200 W/wnotib  ( 1088): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(981) > No postponed update with is_for_VI: 1.
09-09 12:30:01.150+0200 W/W_HOME  ( 1088): home_navigation.c: _anim_stop_cb(1319) > anim stop
09-09 12:30:01.150+0200 W/W_HOME  ( 1088): home_navigation.c: _nav_finish_timer_del(822) > delete timer
09-09 12:30:01.150+0200 W/W_HOME  ( 1088): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
09-09 12:30:01.150+0200 W/W_HOME  ( 1088): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
09-09 12:30:01.150+0200 I/efl-extension( 1088): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x4605f240 : elm_scroller] detent_count(1)
09-09 12:30:01.150+0200 I/efl-extension( 1088): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x4605f240 : elm_scroller] pagenumber_v(0), pagenumber_h(3)
09-09 12:30:01.150+0200 I/efl-extension( 1088): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x4605f240 : elm_scroller] CurrentPage(3)
09-09 12:30:01.150+0200 E/EFL     ( 1088): elementary<1088> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x4605f240 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
09-09 12:30:01.215+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
09-09 12:30:01.215+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
09-09 12:30:01.215+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
09-09 12:30:01.215+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
09-09 12:30:01.230+0200 W/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
09-09 12:30:01.230+0200 E/WAKEUP-SERVICE( 1291): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
09-09 12:30:01.235+0200 E/WAKEUP-SERVICE( 1291): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
09-09 12:30:01.235+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
09-09 12:30:01.255+0200 I/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
09-09 12:30:01.260+0200 W/TIZEN_N_SOUND_MANAGER( 1291): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-09 12:30:01.265+0200 W/WAKEUP-SERVICE( 1291): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
09-09 12:30:01.275+0200 I/HIGEAR  ( 1291): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
09-09 12:30:01.275+0200 E/W_HOME  ( 1088): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
09-09 12:30:01.300+0200 W/W_HOME  ( 1088): event_manager.c: _home_scroll_cb(579) > scroll,will,done
09-09 12:30:01.300+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-09 12:30:01.300+0200 W/W_HOME  ( 1088): event_manager.c: _home_scroll_cb(579) > scroll,done
09-09 12:30:01.300+0200 W/W_HOME  ( 1088): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (squirrel2GHZ)
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 3
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 15 / signal : type_wifi_connected_03
09-09 12:30:01.570+0200 E/W_INDICATOR( 1003): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (15)(0)
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
09-09 12:30:01.570+0200 E/W_INDICATOR( 1003): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
09-09 12:30:01.570+0200 W/W_INDICATOR( 1003): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
09-09 12:30:01.660+0200 W/W_HOME  ( 1088): index.c: index_hide(338) > hide VI:1 visibility:1 vi:(nil)
09-09 12:30:01.815+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.880+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.880+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-service.c: _music_control_service_pasre_request(565) > [33m[TID:1500]   [com.samsung.w-home]register msg port [true][0m
09-09 12:30:01.910+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 14
09-09 12:30:01.915+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1088
09-09 12:30:01.915+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 12:30:01.920+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:30:01.920+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:30:01.920+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 12:30:01.920+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.920+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.925+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.925+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:30:01.925+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:30:01.930+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1500]   [MUSIC_PLAYER_EVENT][0m
09-09 12:30:01.935+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
09-09 12:30:01.935+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
09-09 12:30:01.935+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1500): preference.c: preference_get_int(1132) > preference_get_int(1500) : key(music-control-service_native/playing_diration) error
09-09 12:30:01.935+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-info.c: music_control_info_get_player_position(626) > [31m[TID:1500]   preference_get_int() .. [0xfef00030][0m
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.935+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.940+0200 W/W_HOME  ( 1088): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
09-09 12:30:01.940+0200 E/W_HOME  ( 1088): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-09 12:30:01.945+0200 I/TIZEN_N_SOUND_MANAGER( 1500): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000225
09-09 12:30:01.945+0200 E/TIZEN_N_SOUND_MANAGER( 1500): sound_manager_private.c: __convert_sound_manager_error_code(158) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000225)
09-09 12:30:01.945+0200 W/MUSIC_CONTROL_SERVICE( 1500): music-control-sound-manager.c: music_control_sound_mgr_get_volume(109) > [31m[TID:1500]   sound_manager_get_volume() .. [0xfe6a0001][0m
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:01.945+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-09 12:30:01.950+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:04.180+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5118693 button=1
09-09 12:30:04.180+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:30:04.180+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:30:04.180+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [163, 156]
09-09 12:30:04.180+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2428) >  [249, 249, 249, 102]
09-09 12:30:04.180+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:30:04.180+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:30:04.180+0200 E/EFL     ( 1088): evas_main<1088> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-09 12:30:04.180+0200 E/W_HOME  ( 1088): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
09-09 12:30:04.210+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:30:04.230+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:30:04.240+0200 W/W_HOME  ( 1088): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
09-09 12:30:04.250+0200 E/EFL     ( 1088): ecore_x<1088> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5118768 button=1
09-09 12:30:04.255+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [163, 156]->[165, 154]
09-09 12:30:04.255+0200 W/APPS    ( 1088): AppsViewNecklace.cpp: onBubbleButtonEffect(2446) >  [249, 249, 249, 255]
09-09 12:30:04.255+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,14]
09-09 12:30:04.255+0200 E/APPS    ( 1088): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
09-09 12:30:04.255+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(502) >  item(watchapp) launched, open(0), tts(0)
09-09 12:30:04.255+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(284) > request cmd(0) to(co.za.littlekidogo.watchapp)
09-09 12:30:04.260+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(669) > __request_handler: 0
09-09 12:30:04.260+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1782) > caller pid : 1088
09-09 12:30:04.260+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
09-09 12:30:04.270+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2218) > pad pid(-5)
09-09 12:30:04.275+0200 W/AUL_PAD ( 1235): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-09 12:30:04.275+0200 W/AUL_PAD ( 1235): launchpad.c: __send_result_to_caller(272) > Check app launching
09-09 12:30:04.275+0200 E/RESOURCED(  681): block.c: block_prelaunch_state(138) > insert data co.za.littlekidogo.watchapp, table num : 3
09-09 12:30:04.275+0200 W/AUL_PAD ( 9550): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-09 12:30:04.275+0200 W/AUL_PAD ( 9550): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-09 12:30:04.275+0200 W/AUL_PAD ( 9550): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-09 12:30:04.275+0200 W/AUL_PAD ( 9550): launchpad_loader.c: main(680) > [candidate] dlopen(co.za.littlekidogo.watchapp)
09-09 12:30:04.320+0200 I/efl-extension( 9550): efl_extension.c: eext_mod_init(40) > Init
09-09 12:30:04.325+0200 I/UXT     ( 9550): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-09 12:30:04.325+0200 W/AUL_PAD ( 9550): launchpad_loader.c: main(690) > [candidate] dlsym
09-09 12:30:04.325+0200 W/AUL_PAD ( 9550): launchpad_loader.c: main(694) > [candidate] dl_main(co.za.littlekidogo.watchapp)
09-09 12:30:04.325+0200 I/CAPI_APPFW_APPLICATION( 9550): app_main.c: ui_app_main(704) > app_efl_main
09-09 12:30:04.330+0200 I/CAPI_APPFW_APPLICATION( 9550): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-09 12:30:04.375+0200 W/AUL     (  509): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(co.za.littlekidogo.watchapp) pid(9550) type(uiapp) bg(0)
09-09 12:30:04.375+0200 W/AUL_AMD (  509): amd_status.c: __socket_monitor_cb(1277) > (9550) was created
09-09 12:30:04.375+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-09 12:30:04.375+0200 W/STARTER (  964): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [9550]
09-09 12:30:04.375+0200 W/AUL     ( 1088): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9550)
09-09 12:30:04.375+0200 W/W_HOME  ( 1088): util.c: apps_util_launch_main_operation(785) > Launch app:[watchapp] ret:[0]
09-09 12:30:04.380+0200 W/W_HOME  ( 1088): util.c: send_launch_appId(620) > launch appid[co.za.littlekidogo.watchapp]
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
09-09 12:30:04.380+0200 E/MESSAGE_PORT(  505): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-09 12:30:04.380+0200 I/MESSAGE_PORT(  505): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-09 12:30:04.380+0200 E/MESSAGE_PORT( 1088): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (Apptray.Message.Launch.AppId) is not found.
09-09 12:30:04.380+0200 E/W_HOME  ( 1088): util.c: send_launch_appId(636) > There is no remote message port
09-09 12:30:04.380+0200 W/APPS    ( 1088): AppsItem.cpp: onItemClicked(536) >  appid(co.za.littlekidogo.watchapp)  pkgid(co.za.littlekidogo.watchapp), name(watchapp)
09-09 12:30:04.500+0200 E/EFL     ( 9550): ecore_evas<9550> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-09 12:30:04.620+0200 I/watchapp( 9550): watchapp.c: create_base_gui(82) > adding Do GTD Review
09-09 12:30:04.620+0200 I/watchapp( 9550): watchapp.c: create_base_gui(82) > adding Build Watch Prototype
09-09 12:30:04.620+0200 I/watchapp( 9550): watchapp.c: create_base_gui(82) > adding Research African Markets
09-09 12:30:04.620+0200 I/watchapp( 9550): watchapp.c: create_base_gui(82) > adding Go to Durbanville for Lunch
09-09 12:30:04.730+0200 W/CRASH_MANAGER( 9111): worker.c: worker_job(1205) > 1109550776174153648900
