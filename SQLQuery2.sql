select dateadd(dd,i,CONVERT(datetime, '01/01/2017', 103)) as The_Date
     , 50-sum(NumberOfRooms)  as RoomsAvailable
  from Bookings, Integer
 where i between 1 and 20
   and ArrivalDate <= dateadd(dd,i,CONVERT(datetime, '01/01/2017', 103))
   and dateadd(dd,Duration,ArrivalDate)  > dateadd(dd,i, CONVERT(datetime, '01/01/2017', 103))
group by i
order by RoomsAvailable
