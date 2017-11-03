select dateadd(dd,i,CONVERT(datetime, '01/12/2017', 103)) as The_Date
     , 50-sum(NumberOfRooms)  as RoomsAvailable
  from Bookings, IntegerTable
 where i between 0 and 10
   and ArrivalDate <= dateadd(dd,i,CONVERT(datetime, '01/12/2017', 103))
   and DepartureDate  > dateadd(dd,i, CONVERT(datetime, '01/12/2017', 103))
group by i
order by RoomsAvailable
