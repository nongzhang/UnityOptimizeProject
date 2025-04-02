# UnityOptimizedProject
Unity项目性能优化实践

项目未优化时的一些参考指标数据

- 生成的Android APK大小  1.23G
- 三角形平均面数 2.0M左右
- 渲染批次 Batches 2200—4000
- SetPass calls  140 —180
- realme GT 骁龙888 8G内存  帧率14-26
  
项目优化后的一些参考指标数据

- 生成的Android APK大小  418M
- 三角形平均面数 637K左右
- 渲染批次 Batches 1050
- SetPass calls  83
- realme GT 骁龙888 8G内存  帧率30 （由于移动端硬件设置了垂直同步，帧率被锁定为屏幕刷新率的约数（如 60Hz → 60/30/20/15fps））

  
  
